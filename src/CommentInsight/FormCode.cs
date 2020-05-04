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
    public partial class FormCode : Form
    {

        public string _fileName = "";

        static string path;
        static string pattern = @"/\*(?:(?!\*/)(?:.|[\r\n]+))*\*/";
        
        static string pattern_1line = @"((?<!:)//[^\n]+)";
        static string fileText = "";

        public List<string> fileList;
        public int index = 0;

        public  List<string> commentList;

        public bool allComment = true;

        
        public SortedList<int, Match> matchRegexList = new SortedList<int, Match>();

        private Options App_Config;

        
        
        
        

        public FormCode(Options appConfig)
        {
            InitializeComponent();

            App_Config = appConfig;
        }

        private void FormCode_Load(object sender, EventArgs e)
        {
            commentList = new List<string>();
            if (fileList != null)
            {
                foreach(string ls in fileList)
                    comboBox1_FileList.Items.Add(ls);
            }

            if (comboBox1_FileList.Items.Count > 0)
            {
                open_codeFile(0);
                
            }

            this.KeyPreview = true;

        }

        public void open_codeFile(int index)
        {
            matchRegexList.Clear();
            commentList.Clear();

            if (index >= comboBox1_FileList.Items.Count)
                index = 0;

            if (index <0)
                index = comboBox1_FileList.Items.Count -1;

            comboBox1_FileList.SelectedIndex = index;
            path = comboBox1_FileList.Text;
            
            StreamReader streamReader = new StreamReader(path);
            fileText = streamReader.ReadToEnd();
            streamReader.Close();

            
            richTextBox1.Text = "";
            richTextBox1.ForeColor = Color.Black;

            richTextBox2.Text = "";
            richTextBox2.ForeColor = Color.Black;


            richTextBox1.Text = fileText;
            richTextBox2.Text = fileText;

            
            int clearNum = 0;

            CodeHelper codeHelper = new CodeHelper(App_Config);
            codeHelper.prepare_sourcefile(path);
            codeHelper.updateCommentColorMethod = ColoritRed;
            richTextBox2.Text = codeHelper.clear_RichTextbox_comment(richTextBox1, allComment, out clearNum);
            label3_Comment.Text = clearNum.ToString();

            codeHelper.clear_RichTextbox_comment(richTextBox2, allComment, out clearNum);

            this.Text = "Preview Code  [" + (index+1).ToString() + " / " + comboBox1_FileList.Items.Count.ToString()+"]";

            richTextBox1.Select(0, 0);
            richTextBox2.Select(0, 0);

        }


        private string clear_comment(string inputStr)
        {
            string text = "";
            if (allComment == true)
            {

                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                text = regex.Replace(inputStr, "");

                text = Regex.Replace(text, pattern_1line, "");
                return text;
            }
            else
            {
                int regIndex = matchRegexList.Count - 1;
                while (regIndex >= 0)
                {
                    int iKey = matchRegexList.Keys[regIndex];
                    Match m = (Match)matchRegexList[iKey];

                    inputStr = inputStr.Remove(m.Index, m.Length);

                    regIndex--;
                }

                text = inputStr;

            }

            return text;

        }
        public bool isValidComment(Match m)
        {
            string comment = m.Value;
            bool bret = true;

            if (allComment == false)
            {
                
                Regex regex = new Regex(@"[^(\x00-\x7f)]", RegexOptions.IgnoreCase);

                bret = regex.IsMatch(comment);
                if(bret)
                    matchRegexList.Add(m.Index, m);
            }

            return bret;
        }

        private int ColoritRed(RichTextBox rtb, string StringToHighlight,int pos, Color textColor)
        {
            if (pos < 0) pos = 0;

            string searchText = StringToHighlight.Replace("\r\n","\r");
            int pos11 = rtb.Find(searchText,pos, RichTextBoxFinds.None);
            while (pos11 != -1)
            {
                if (rtb.SelectedText.Length == searchText.Length)
                {
                    this.ActiveControl = rtb;
                    rtb.SelectionStart = pos11;
                    rtb.SelectionLength = searchText.Length;
                    rtb.SelectionColor = textColor;
                }

                break;
            }

            

            return pos11 + searchText.Length;
        }

        

        private void button1_Pre_Click(object sender, EventArgs e)
        {
            open_codeFile(comboBox1_FileList.SelectedIndex-1);
        }

        private void button2_Next_Click(object sender, EventArgs e)
        {
            open_codeFile(comboBox1_FileList.SelectedIndex+1);
        }

        private void button3_Clear_Click(object sender, EventArgs e)
        {

            
            
            
            open_codeFile(comboBox1_FileList.SelectedIndex);
        }


        
        

        
        
        
        

        

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

        

        

        private void radioButton1_all_CheckedChanged(object sender, EventArgs e)
        {

            if (allComment == false)
            {
                richTextBox1.BeginUpdate();
                richTextBox2.BeginUpdate();

                allComment = true;
                open_codeFile(comboBox1_FileList.SelectedIndex);


                richTextBox1.EndUpdate();
                richTextBox2.EndUpdate();
            }

        }

        private void radioButton2_notAscii_CheckedChanged(object sender, EventArgs e)
        {
            if (allComment == true)
            {
                richTextBox1.BeginUpdate();
                richTextBox2.BeginUpdate();

                allComment = false;

                open_codeFile(comboBox1_FileList.SelectedIndex);

                richTextBox1.EndUpdate();
                richTextBox2.EndUpdate();


            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            int crntLastLine = GetLineNoVscroll(richTextBox1);
            TrunRowsId(crntLastLine, richTextBox2);
        }

        private int GetLineNoVscroll(RichTextBox rtb)
        {
            Point p = rtb.Location;
            int crntFirstIndex = rtb.GetCharIndexFromPosition(p);
            int crntFirstLine = rtb.GetLineFromCharIndex(crntFirstIndex);
            return crntFirstLine;
        }

        private void TrunRowsId(int iCodeRowsID, RichTextBox rtb)
        {
            try
            {
                rtb.SelectionStart = rtb.GetFirstCharIndexFromLine(iCodeRowsID);
                rtb.SelectionLength = 0;
                rtb.ScrollToCaret();
            }
            catch
            {

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            

            DialogResult MsgBoxResult = MessageBox.Show("Confirm save clear code to file:",
            "ComentInsight",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.Yes)
            {
                
                string lsPath = comboBox1_FileList.Text;
                var enc = FileHelper.GetEncoding(lsPath);

                
                String lsOriText = System.IO.File.ReadAllText(lsPath, enc);
                string lsBakPath = lsPath +".bak";
                if (System.IO.File.Exists(lsBakPath) == false)
                    System.IO.File.WriteAllText(lsBakPath, lsOriText, enc);

                
                Encoding utf8WithoutBom = new UTF8Encoding(false);
                string cleanCode = richTextBox2.Text.Replace("\n","\r\n");
                System.IO.File.WriteAllText(lsPath, cleanCode, enc);

                Close();
            }
        }

        private void FormCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void Button1_Compare_Click(object sender, EventArgs e)
        {

        }

        private void Button1_CommentOptions_Click(object sender, EventArgs e)
        {
            
            FormOptions form = new FormOptions(ConfigPageEmnu.ConfigPage_Comment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                App_Config.load_config();
                open_codeFile(comboBox1_FileList.SelectedIndex);
            }
        }
    }
}


