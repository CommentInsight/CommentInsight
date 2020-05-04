using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    public enum SFileType
    {
        FixedDrive_item = 0,
        Folder_item = 1,
        File_item = 2,
    }

    public partial class MainForm : Form
    {
        private Options App_Config;
        
        
        

        public string lastOpenFolder = "";

        private int File_Num = 0;

        private int Total_Lines_Num = 0;
        private int Comment_Lines_Num = 0;
        private int Comment_Spaces_Num = 0;
        
        
        
        

        
        

        private FormWait waitForm;

        
        

        private ListViewColumnSorter lvwColumnSorter;

        
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void FileManForm_Load(object sender, EventArgs e)
        {
            App_Config = new Options();
            load_config();

            comboBox_FilePath.Items.Add(Application.StartupPath);
            this.comboBox_FilePath.SelectedIndex = 0;

            comboBox_Filter.Items.Add(App_Config.FileExt);
            comboBox_Filter.SelectedIndex = 0;

            

            openSelectFolder(comboBox_FilePath.Text);

            waitForm = new FormWait();

            lvwColumnSorter = new ListViewColumnSorter();
            listView_Filelist.ListViewItemSorter = lvwColumnSorter;

            timer1.Interval = 10 * 1000;
            timer1.Enabled = true;

        }

        private void load_config()
        {
            App_Config.load_config();

            
            
            

            
            
        }

        private void button1_Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = comboBox_FilePath.Text;

            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                comboBox_FilePath.Items.Add(folderDlg.SelectedPath);
                comboBox_FilePath.Text = folderDlg.SelectedPath;

                openSelectFolder(comboBox_FilePath.Text);
            }
        }
        private void Button2_SearchFiles_Click(object sender, EventArgs e)
        {
            
            openSelectFolder(comboBox_FilePath.Text);
        }


        private void comboBox_FilePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void ComboBox_FilePath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                openSelectFolder(comboBox_FilePath.Text);
            }
        }
        private void openSelectFolder(string lsPath)
        {
            
            
            
            
            
            
            
            

            string opPath = comboBox_FilePath.Text;
            string ofExt = comboBox_Filter.Text;
            if (System.IO.Directory.Exists(opPath))
            {
                Sources sources = new Sources(App_Config, checkBox1_SubFolder.Checked);

                List<Dictionary<string, string>> fileList = sources.queryFilelists(opPath, ofExt);
                addFileItems(fileList);

                lastOpenFolder = opPath;

                textBox1_FileNum.Text = File_Num.ToString();


                Total_Lines_Num = 0;
                Comment_Lines_Num = 0;
                Comment_Spaces_Num = 0;

                checkFilesEncoding();

                if ((waitForm != null) && (File_Num > 100))
                {
                    waitForm.Close();

                    waitForm = new FormWait();
                    waitForm.setTipstr(0);
                    waitForm.ShowDialog();
                }

                if (comboBox_FilePath.Items.IndexOf(lsPath) < 0)
                    comboBox_FilePath.Items.Add(lsPath);

            }

            listView_Filelist.Focus();
        }
                    

        private void addFileItems(List<Dictionary<string, string>> fileList)
        {
            this.listView_Filelist.Items.Clear();
            this.listView_Filelist.BeginUpdate();

            File_Num = 0;

            for (int i = 0; i < fileList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = fileList[i]["name"];
                lvi.SubItems.Add(fileList[i]["size"]);
                lvi.SubItems.Add(fileList[i]["lastModified"]);
                lvi.SubItems.Add("");

                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");

                lvi.SubItems.Add("");

                string fileType = fileList[i]["type"];
                if (fileType == SFileType.File_item.ToString())
                {
                    lvi.ImageIndex = (int)SFileType.File_item;
                    File_Num++;
                }
                else
                    lvi.ImageIndex = (int)SFileType.Folder_item;

                lvi.Tag = Path.Combine(lastOpenFolder, lvi.Text);

                this.listView_Filelist.Items.Add(lvi);
            }

            this.listView_Filelist.EndUpdate();
        }

        

        private void listView_Filelist_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            if (sitem.ImageIndex == (int)SFileType.Folder_item)
            {
                try
                {
                    string sfilePath = "";
                    if (sitem.Text == ".")
                    {
                        return;
                    }
                    else if (sitem.Text == "..")
                    {
                        sfilePath = Path.GetDirectoryName(lastOpenFolder);
                    }
                    else
                        sfilePath = Path.Combine(lastOpenFolder, sitem.Text);

                    if (sfilePath != null)
                    {
                        comboBox_FilePath.Text = sfilePath;
                        openSelectFolder(comboBox_FilePath.Text);
                    }


                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
            else
            {
                

                string sfilePath  = Path.Combine(lastOpenFolder, sitem.Text);


                List<String> listPath = new List<string>();
                listPath.Add(sfilePath);

                FormCode codeForm = new FormCode(App_Config);
                codeForm.fileList = listPath;

                codeForm.ShowDialog();

            }
        }

        private void updateItemEncoding(int index, Encoding encoding)
        {
            ListViewItem lvi = listView_Filelist.Items[index];
            if (encoding != null)
            {
                if (encoding.BodyName == "utf-8")
                {
                    Encoding utf8WithoutBom = new UTF8Encoding(true);

                    UTF8Encoding enc8 = (UTF8Encoding)encoding;
                    if (enc8.Equals(utf8WithoutBom))
                        lvi.SubItems[3].Text = "utf-8-bom";
                    else
                        lvi.SubItems[3].Text = "utf-8";

                }
                else
                    lvi.SubItems[3].Text = encoding.BodyName;
            }
        }

        private void updateItemLines(int index, int lines, int comment_lines, int comments)
        {
            ListViewItem lvi = listView_Filelist.Items[index];
            lvi.SubItems[4].Text = lines.ToString();
            lvi.SubItems[5].Text = comment_lines.ToString();
            lvi.SubItems[6].Text = comments.ToString();

        }

        private void GetCommentMemo(int level, ref string comVote, ref string comRating)
        {
            if (level > 90)
            {
                comVote = "En... There is no code. ";
            }
            else if ((level <= 90) && (level > 60))
            {
                comVote = "Oh My God, Comment is everywhere. ";
            }
            else if ((level <= 60) && (level > 30))
            {
                comVote = "Oh...The programer is good guy. Full 5-star rating";
                comRating = "★★★★★";
            }
            else if ((level <= 30) && (level > 10))
            {
                comVote = "Oh yeah, Comment is working.";
                comRating = "★★★★";
            }
            else if ((level <= 10) && (level > 5))
            {
                comVote = "Oh... Comment is less, but better then none. ";
                comRating = "★★★";
            }
            else if ((level <= 5) && (level > 3))
            {
                comVote = "En... Maybe the programer is an lazy guy. ";
                comRating = "★★";
            }
            else if ((level <= 3) && (level >= 1))
            {
                comVote = "Where is the Comment? I can't see it. ";
                comRating = "★";
            }
            else
            {
                comRating = "☆";
                comVote = "En... Only God can reading this code.";
            }
        }
        private void UpdateCommentLevel(int level)
        {
            string  comVote = "";
            string  comRating = "";

            GetCommentMemo(level, ref comVote,ref  comRating);

            
            textBox2_CommentRating.Text = comRating;
            textBox3_CommentRatio.Text = level.ToString() + "%";

            
            
            

            
            
            
            

        }

        private void detectFileEncoding(SortedList<int, string> list_path)
        {


            IList<int> iKeys = list_path.Keys;

            for (int i = 0; i < list_path.Count; i++)
            {
                int index = iKeys[i];
                var lsPath = list_path[index].ToString();
                var encoding = FileHelper.GetEncoding(lsPath);


                int lines, comments, comment_lines;
                CodeHelper coHelper = new CodeHelper(App_Config);
                coHelper.get_srouce_comment_lines(lsPath, encoding,out lines, out comments, out comment_lines);


                Total_Lines_Num += lines;
                Comment_Lines_Num += comment_lines;
                Comment_Spaces_Num += comments;

                this.Invoke(new Action(() => {
                    updateItemEncoding(index, encoding);
                    updateItemLines(index, lines, comment_lines, comments);
                }));
            }

            Thread.Sleep(1000);
            this.Invoke(new Action(() => {
                updateFileListStatus();
            }));

            this.Invoke(new Action(() => {
                if (waitForm != null)
                {
                    waitForm.Close();
                }
            }));



            
            
            
            
            
            
            

            
            
            
            
            

            
            
            
            
        }

        private void checkFilesEncoding()
        {
            SortedList<int, string> list_path = new SortedList<int, string>();

            int listNum = listView_Filelist.Items.Count;
            

            for (int i = 0; i < listNum; i++)
            {
                ListViewItem lvi = listView_Filelist.Items[i];

                if (lvi.ImageIndex != (int)SFileType.File_item)
                    continue;

                
                string lsPath = Path.Combine(lastOpenFolder, lvi.Text);
                list_path.Add(i, lsPath);
            }


            Task task = Task.Factory.StartNew(() =>
            {
                detectFileEncoding(list_path);
            });
        }
        private void button1_DetectEncoding_Click(object sender, EventArgs e)
        {

            
        }

        private void convertItem2UTF8(ListViewItem lvi)
        {


            if (lvi.ImageIndex != (int)SFileType.File_item)
                return;

            string lsPath = lvi.Text;
            lsPath = Path.Combine(lastOpenFolder, lsPath);

            
            
            
            
            
            

            if ((lvi.SubItems[3].Text == "") || (lvi.SubItems[3].Text == "utf-8"))
            {
                lvi.SubItems[7].Text = "pass";
                return;
            }

            try
            {
                encodingFileWithUTF8(lsPath, lvi.SubItems[3].Text);
                lvi.SubItems[3].Text = "utf-8";

                lvi.SubItems[7].Text = "--> done";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ConvertToUTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int listNum = listView_Filelist.SelectedItems.Count;
            for (int i = 0; i < listNum; i++)
            {
                ListViewItem lvi = listView_Filelist.SelectedItems[i];
                convertItem2UTF8(lvi);
            }

            MessageBox.Show("Convert Finish!", "CommentCleanTool");
        }

        private void button1_ConvertUTF8_Click(object sender, EventArgs e)
        {
            int listNum = listView_Filelist.Items.Count;

            for (int i = 0; i < listNum; i++)
            {
                ListViewItem lvi = listView_Filelist.Items[i];
                convertItem2UTF8(lvi);
            }

            
            MessageBox.Show("Convert Finish!","CommentCleanTool");
        }

        private void encodingFileWithUTF8(string lsPath,string encName)
        {
            string lsBakPath = lsPath + ".bak";
            if(System.IO.File.Exists(lsBakPath) == false)
                System.IO.File.Move(lsPath, lsBakPath);

            if (encName == "utf-8-bom")
                encName = "utf-8";

            Encoding enc = Encoding.GetEncoding(encName);
            String lsText = System.IO.File.ReadAllText(lsBakPath, enc);

            Encoding utf8WithoutBom = new UTF8Encoding(false);
            System.IO.File.WriteAllText(lsPath, lsText, utf8WithoutBom);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if ((App_Config.DiffToolPath == null) || (!System.IO.File.Exists(App_Config.DiffToolPath)))
            {
                extenDiffToolStripMenuItem.Enabled = false;
            }
            else
            {
                extenDiffToolStripMenuItem.Enabled = true;
            }

        }

        private void copyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            string sfilePath = sitem.Text;

            if (sfilePath != "..")
                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
            else
                sfilePath = lastOpenFolder;


            Clipboard.SetText(sfilePath);
        }
        private void FilenameToClipBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            Clipboard.SetText(sitem.Text);

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            string sfilePath = sitem.Text;

            if (sfilePath != "..")
                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
            else
                sfilePath = lastOpenFolder;

            System.Diagnostics.Process.Start("explorer.exe", sfilePath);
        }

        private void explorerHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            string sfilePath = sitem.Text;

            if (sfilePath != "..")
                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
            else
                sfilePath = lastOpenFolder;

            if (sitem.ImageIndex == (int)SFileType.File_item)
                sfilePath = Path.GetDirectoryName(sfilePath);

            System.Diagnostics.Process.Start("explorer.exe", sfilePath);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            var sitem = listView_Filelist.SelectedItems[0];
            string sfilePath = sitem.Text;


            if (sfilePath != "..")
                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
            else
                sfilePath = lastOpenFolder;

            if (sitem.ImageIndex == (int)SFileType.File_item)
                sfilePath = Path.GetDirectoryName(sfilePath);
            else
                sfilePath += "\\";

            sfilePath = " /k cd /d \"" + sfilePath + "\"";

            System.Diagnostics.Process.Start("cmd.exe", sfilePath);
        }


        private void preview_FileComment(List<String> listPath)
        {
            FormCode codeForm = new FormCode(App_Config);
            codeForm.fileList = listPath;

            codeForm.ShowDialog();
        }
        private void clear_FileComment(List<String> listPath)
        {
            FormCleaner cleanForm = new FormCleaner(App_Config);
            cleanForm.clean_filelists(lastOpenFolder,listPath);

            cleanForm.ShowDialog();
        }
        private void button_ClearComment_Click(object sender, EventArgs e)
        {
            List<String> listPath = new List<string>();

            foreach (ListViewItem sitem in listView_Filelist.Items)
            {
                if (sitem.ImageIndex != (int)SFileType.File_item)
                    continue;

                string sfilePath = sitem.Text;
                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);

                listPath.Add(sfilePath);
            }

            clear_FileComment(listPath);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;


            List<String> listPath = new List<string>();

            foreach (ListViewItem sitem in listView_Filelist.SelectedItems)
            {
                if (sitem.ImageIndex != (int)SFileType.File_item)
                    continue;

                string sfilePath = sitem.Text;

                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
                listPath.Add(sfilePath);

            }

            preview_FileComment(listPath);
        }

        private void Label27_Click(object sender, EventArgs e)
        {

        }

        private void OpenDiffTool(string lsSrcfile)
        {
            if ((App_Config.DiffToolPath != null)&&(System.IO.File.Exists(App_Config.DiffToolPath) == false))
            {
                return;
            }

            string lsTempFile = System.IO.Path.GetTempFileName();
            if (System.IO.File.Exists(lsSrcfile))
            {
                var encoding = FileHelper.GetEncoding(lsSrcfile);

                int lines, comments, comment_lines;
                CodeHelper coHelper = new CodeHelper(App_Config);

                string cccode = coHelper.get_srouce_comment_lines(lsSrcfile, encoding, out lines, out comments, out comment_lines);

                try
                {
                    System.IO.File.WriteAllText(lsTempFile, cccode, encoding);


                    
                    string sfilePath = string.Format("\"{0}\" \"{1}\" ",lsSrcfile,lsTempFile);

                    System.Diagnostics.Process.Start(App_Config.DiffToolPath, sfilePath);

                }
                catch (Exception ex)
                {
                }
            }

        }

        private void ExtenDiffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            string sfilePath = "";

            foreach (ListViewItem sitem in listView_Filelist.SelectedItems)
            {
                if (sitem.ImageIndex != (int)SFileType.File_item)
                    continue;

                sfilePath = Path.Combine(lastOpenFolder, sitem.Text);
            }

            if (System.IO.File.Exists(sfilePath) == false)
            {
                return;
            }

            
            if ((App_Config.DiffToolPath == null) || (!System.IO.File.Exists(App_Config.DiffToolPath)))
            {
                
                MessageBox.Show("Please setup diff tool in options.");
            }
            else
            {
                OpenDiffTool(sfilePath);
            }

        }

        private string getGitPath(string lsPath)
        {
            string lsUrl = lsPath;
            string gitConfigPath = Path.Combine(lsPath, @".git\config");
            if (System.IO.File.Exists(gitConfigPath))
            {
                
                String lsText = System.IO.File.ReadAllText(gitConfigPath);

                

                Regex re = new Regex(@"(?<url>(http(s)?|git)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?)");
                MatchCollection mc = re.Matches(lsText);
                foreach (Match m in mc)
                {
                    lsUrl = m.Result("${url}");
                    break;
                }
            }
            

            return lsUrl;
        }

        private void Button3_SaveRating_Click(object sender, EventArgs e)
        {
            string lsPath = (comboBox_FilePath.Text);
            if (!System.IO.Directory.Exists(lsPath))
            {
                return;
            }

            lsPath = getGitPath(lsPath);



            ListViewItem lvi = new ListViewItem();

            string lsFolderName = lastOpenFolder;
            if ((lastOpenFolder[lastOpenFolder.Length - 1] == '\\') || (lastOpenFolder[lastOpenFolder.Length - 1] == '/'))
                lsFolderName = lastOpenFolder.Substring(0, lastOpenFolder.Length - 1);

            lvi.Text = Path.GetFileName(lsFolderName);
            lvi.SubItems.Add(lsPath);
            lvi.SubItems.Add(textBox1_FileNum.Text);
            lvi.SubItems.Add(textBox2_TotalLines.Text);
            lvi.SubItems.Add(textBox3_CommentLines.Text);
            lvi.SubItems.Add(textBox3_CommentRatio.Text);

            int level = int.Parse(textBox3_CommentRatio.Text.Replace('%',' '));
            string comVote = "";
            string comRating = "";
            GetCommentMemo(level, ref comVote, ref comRating);

            lvi.SubItems.Add(comRating);
            lvi.SubItems.Add(comVote);
            
            this.listView_CommentRating.Items.Add(lvi);

            tabControl1.SelectedIndex = 1;

        }

        private void Button2_ClearRating_Click(object sender, EventArgs e)
        {
            if (this.listView_CommentRating.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem sitem in listView_CommentRating.SelectedItems)
            {

                listView_CommentRating.Items.Remove(sitem);

            }
        }

        private void IgnoreFolderInSourceFile(string lsFolder)
        {

            foreach (ListViewItem sitem in listView_Filelist.Items)
            {
                if (sitem.Text == "..") continue;

                if (sitem.Text.IndexOf(lsFolder) == 0)
                {
                    listView_Filelist.Items.Remove(sitem);
                }
            }
        }

        private void IgnoreSelectedFilesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            listView_Filelist.BeginUpdate();
            foreach (ListViewItem sitem in listView_Filelist.SelectedItems)
            {
                if (sitem.Text == "..") continue;

                if (sitem.ImageIndex == (int)SFileType.Folder_item)
                {
                    IgnoreFolderInSourceFile(sitem.Text);
                }
            }

            listView_Filelist.EndUpdate();

            this.Invoke(new Action(() => {
                updateFileListStatus();
            }));
        }

        private void IgnoreCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView_Filelist.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem sitem in listView_Filelist.SelectedItems)
            {
                if (sitem.Text == "..") continue;

                if (sitem.ImageIndex == (int)SFileType.File_item)
                {
                    listView_Filelist.Items.Remove(sitem);
                }
            }

            this.Invoke(new Action(() => {
                updateFileListStatus();
            }));
        }

        private void updateFileListStatus()
        {
            int aFileNum = 0;
            int aTotal_Lines_Num = 0;
            int aComment_Lines_Num = 0;
            int aComment_Spaces_Num = 0;


            foreach (ListViewItem sitem in listView_Filelist.Items)
            {
                if (sitem.ImageIndex == (int)SFileType.File_item)
                    aFileNum+=1;

                if (sitem.SubItems[4].Text == "")
                    continue;

                aTotal_Lines_Num += Convert.ToInt32(sitem.SubItems[4].Text);
                aComment_Lines_Num += Convert.ToInt32(sitem.SubItems[5].Text);
                aComment_Spaces_Num += Convert.ToInt32(sitem.SubItems[6].Text);
            }

            
            

            Total_Lines_Num = aTotal_Lines_Num;
            Comment_Lines_Num = aComment_Lines_Num;

            int ct_radio = 0;
            decimal A = (decimal)Comment_Lines_Num;
            decimal B = (decimal)Total_Lines_Num;

            if ((Comment_Lines_Num > 0) && (Total_Lines_Num > 0))
            {
                decimal t = decimal.Parse((A / B).ToString("0.000"));
                var t1 = Math.Round(t, 2);
                var t2 = t1 * 100;

                ct_radio = (int)(t1 * 100);
            }


            this.Invoke(new Action(() => {
                
                textBox1_FileNum.Text = aFileNum.ToString();
                textBox2_TotalLines.Text = Total_Lines_Num.ToString();
                textBox3_CommentLines.Text = Comment_Lines_Num.ToString();
            }));

            this.Invoke(new Action(() => {
                UpdateCommentLevel(ct_radio);
            }));

        }

        private void ListView_Filelist_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            
            this.listView_Filelist.Sort();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = Convert.ToDateTime("2020-08-01 12:34:56");

            int d1d2 = dt1.CompareTo(dt2);
            if (d1d2 > 0)
            {
                MessageBox.Show("Beta version expired, please download new version.");
                this.Invoke(new Action(() => {
                    label1_CommentLevel.Text = "Beta version expired, please download new version.";
                }));
            }

        }



        private void TreeView_OptionMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
         }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Button_options_Click(object sender, EventArgs e)
        {
            
            FormOptions form = new FormOptions();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
                load_config();
                openSelectFolder(comboBox_FilePath.Text);
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/commentinsight");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://commentinsight.github.io/");
        }
    }
}
