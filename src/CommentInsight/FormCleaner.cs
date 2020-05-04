using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    public partial class FormCleaner : Form
    {
        private Options App_Config;

        private bool isCleanning = false;
        private bool isPause = false;
        private bool isFinish = false;

        private int _file_index = 0;

        public string _fileName = "";

        
        
        
        

        private string clearFolder;
        private List<string> fileList;

        public List<string> commentList;

        public bool allComment = true;

        private int Total_Lines_Num = 0;
        private int Comment_Lines_Num = 0;
        private int Comment_Num = 0;

        
        

        private int BackupType;
        private string BackupPath;


        
        
        
        

        public FormCleaner(Options appConfig)
        {
            InitializeComponent();

            App_Config = appConfig;
        }


        private void FormCleaner_Load(object sender, EventArgs e)
        {
            
            

            load_config();
        }

        public void clean_filelists(string cFolder,List<string> files)
        {
            clearFolder = cFolder;
            fileList = files;
        }

        private void load_config()
        {
            BackupType = Convert.ToInt32( ConfigHelper.GetAppConfig("BackupType", "0"));
            BackupPath = ConfigHelper.GetAppConfig("BackupPath", ".");

            if (fileList.Count > 1)
                label_CurrentFile.Text = fileList[0];

            textBox1_FileNum.Text = fileList.Count.ToString();

            label_CurrentFile.Text = "";

            progressBar_Clean.Value = 0;
            progressBar_Clean.Maximum = fileList.Count;

            isCleanning = false;
            isPause = false;

            UpdateUI(isCleanning);
        }
        private void Button1_Start_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                isPause = false;
            }
            else
            {
                Comment_Lines_Num = 0;
                Comment_Num = 0;
            }

            isCleanning = true;

            bool bAllComment = radioButton1_all.Checked;

            Task task = Task.Factory.StartNew(() =>
            {
                cleanFileComment(fileList, bAllComment);
            });

            UpdateUI(isCleanning);
        }

        private void UpdateUI(bool isCleaning)
        {
            isCleanning = isCleaning;
            if (isCleanning)
            {
                radioButton1_all.Enabled = false;
                radioButton2_notAscii.Enabled = false;

                button1_Start.Enabled = false;
                button2_Stop.Enabled = true;
            }
            else
            {
                radioButton1_all.Enabled = true;
                radioButton2_notAscii.Enabled = true;

                button1_Start.Enabled = true;
                button2_Stop.Enabled = false;
            }
        }

        private void FinishClean()
        {
            UpdateUI(true);

            isFinish = true;
            button2_Stop.Text = "Close";

            string strResult = string.Format("Clean {0} Comment.\r\nClean {1} Comment-Lines.", Comment_Num, Comment_Lines_Num);
            MessageBox.Show( strResult, "Clean Done.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (isFinish)
                Close();

            if (isPause != true)
            {
                isPause = true;
                button2_Stop.Enabled = false;
            }
            else {
                Button1_Start_Click(sender, e);

                button2_Stop.Text = "&Pause";
            }
        }
        private void updateItemLines(int CleanNum)
        {
            textBox1_CleanFilesNum.Text = CleanNum.ToString();
            textBox3_CleanCommentLines.Text = Comment_Lines_Num.ToString();
        }

        private void cleanFileComment(List<string> filelist, bool bAll = true)
        {

            for (int index = _file_index; index < filelist.Count; index++)
            {
                var lsPath = filelist[index];

                
                this.Invoke(new Action(() => {
                    label_CurrentFile.Text = lsPath;
                    progressBar_Clean.Increment(1);

                }));

                var encoding = FileHelper.GetEncoding(lsPath);

                int lines, comments, comment_lines;
                CodeHelper coHelper = new CodeHelper(App_Config);

                string cccode = coHelper.get_srouce_comment_lines(lsPath, encoding, out lines, out comments, out comment_lines, bAll);

                try
                {
                    saveCleanFile(lsPath, cccode, encoding);

                    Total_Lines_Num += lines;

                    Comment_Num += comments;
                    Comment_Lines_Num += comment_lines;
                }
                catch (Exception ex)
                {
                }
                

                
                this.Invoke(new Action(() => {
                    updateItemLines(index+1);
                }));

                Thread.Sleep(100);

                _file_index = index;

                if (isPause)
                {
                    this.Invoke(new Action(() => {
                        button2_Stop.Text = "Resume";
                        button2_Stop.Enabled = true;
                    }));

                    break;
                }

            }

            if(isPause == false)
            { 
                this.Invoke(new Action(() => {
                    FinishClean();   
                }));

            }
        }
        private string get_relative_path(string baseDir, string filePath)
        {
            if ((baseDir[baseDir.Length - 1] != '\\') & (baseDir[baseDir.Length - 1] != '/'))
                baseDir = baseDir + "\\";

            System.Uri uri1 = new Uri(filePath);
            System.Uri uri2 = new Uri(baseDir);

            Uri relativeUri = uri2.MakeRelativeUri(uri1);

            string rel_path = relativeUri.ToString().Replace("/", "\\").Replace("%20", " ");


            return rel_path;
        }

        private string getFileBakname(string lsPath)
        {
            string lsbakPath;
            if (BackupPath == ".")
                lsbakPath = lsPath + ".bak";
            else
            {
                string ls_path = get_relative_path(clearFolder,lsPath);
                lsbakPath = Path.Combine(BackupPath, ls_path);


                ls_path = Path.GetDirectoryName(lsbakPath);
                if (Directory.Exists(ls_path) == false)
                    Directory.CreateDirectory(ls_path);
            }

            return lsbakPath;
        }

        private void saveCleanFile(string lsPath, string cleanCode,Encoding enc)
        {
            String lsOriText = System.IO.File.ReadAllText(lsPath, enc);
            string lsBakPath = getFileBakname(lsPath);
            if(System.IO.File.Exists(lsBakPath) == false)
                System.IO.File.WriteAllText(lsBakPath, lsOriText);

            Encoding utf8WithoutBom = new UTF8Encoding(false);
            System.IO.File.WriteAllText(lsPath, cleanCode, utf8WithoutBom);
        }

        private void Button_CommentOptions_Click(object sender, EventArgs e)
        {
            FormOptions form = new FormOptions(ConfigPageEmnu.ConfigPage_Comment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                App_Config.load_config();
                
            }
        }
    }
}

