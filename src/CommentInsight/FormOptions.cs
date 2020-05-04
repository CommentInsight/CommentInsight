using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    public enum ConfigPageEmnu
    {
        ConfigPage_Search =0,
        ConfigPage_Comment = 1,
        ConfigPage_General = 2,
    }
    public partial class FormOptions : Form
    {
        private Options app_options;
        private int PageIndex;

        public FormOptions()
        {
            InitializeComponent();
        }

        public FormOptions(ConfigPageEmnu pagenum)
        {
            InitializeComponent();

            PageIndex = (int)pagenum;
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            app_options = new Options();
            app_options.load_config();

            load_config();

            if (PageIndex > 0)
                tabControl1.SelectedIndex = PageIndex;
        }

        private void reset_ignore()
        {
            Add_Ignore_FolderName(true, @".git", "git resp folder");
            Add_Ignore_FolderName(true, @"comment_backup", "default backup folder");

            Add_Ignore_FileName(true, @".Designer.cs", "C# Form Designer files");

            Add_Comment_Regex(true, @"[^(\x00-\x7f)]", "search not-ASCII comment");
        }

        private void load_config()
        {
            
            try
            {
                if  (app_options.config_inited == false)
                {
                    reset_ignore();
                }

                show_config();

                textBox_FileExt.Text = app_options.FileExt;

                int dindex = Convert.ToInt32(app_options.DiffTool);
                if ((dindex < 0) || (dindex > 3))
                    dindex = 0;

                comboBox1_Diff.SelectedIndex = dindex;
                textBox_DiffToolPath.Text = app_options.DiffToolPath;

                int bindex = Convert.ToInt32(app_options.BackupType);
                radioButton1_bakpath1.Checked = (bindex == 0);
                radioButton2_bakpath2.Checked = (bindex == 1);

                textBox2_bakpath.Text = app_options.BackupPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void save_config()
        {
            app_options.FileExt = textBox_FileExt.Text;
            app_options.DiffTool = comboBox1_Diff.SelectedIndex.ToString();
            app_options.DiffToolPath = textBox_DiffToolPath.Text;

            if (radioButton1_bakpath1.Checked)
                app_options.BackupType = "0";
            else
                app_options.BackupType = "1";

            app_options.BackupPath = textBox2_bakpath.Text;

            app_options.save_config();

        }

        private void show_config() {

            for (int i = 0; i < app_options.folder_configData.jsonData.Count; i++)
            {
                jsonData jData = app_options.folder_configData.jsonData[i];

                int index = dataGridView1_Folder.Rows.Add();
                dataGridView1_Folder.Rows[index].Cells[0].Value = jData.cEnabled;
                dataGridView1_Folder.Rows[index].Cells[1].Value = jData.cName;
                dataGridView1_Folder.Rows[index].Cells[2].Value = jData.cDesc;
            }

            for (int i = 0; i < app_options.file_configData.jsonData.Count; i++)
            {
                jsonData jData = app_options.file_configData.jsonData[i];

                int index = dataGridView1_File.Rows.Add();
                dataGridView1_File.Rows[index].Cells[0].Value = jData.cEnabled;
                dataGridView1_File.Rows[index].Cells[1].Value = jData.cName;
                dataGridView1_File.Rows[index].Cells[2].Value = jData.cDesc;
            }

            for (int i = 0; i < app_options.comment_regexConfig.jsonData.Count; i++)
            {
                jsonData jData = app_options.comment_regexConfig.jsonData[i];

                int index = dataGridView1_CommentRegex.Rows.Add();
                dataGridView1_CommentRegex.Rows[index].Cells[0].Value = jData.cEnabled;
                dataGridView1_CommentRegex.Rows[index].Cells[1].Value = jData.cName;
                dataGridView1_CommentRegex.Rows[index].Cells[2].Value = jData.cDesc;
            }

            for (int i = 0; i < app_options.comment_findConfig.jsonData.Count; i++)
            {
                jsonData jData = app_options.comment_findConfig.jsonData[i];

                int index = dataGridView1_CommentFind.Rows.Add();
                dataGridView1_CommentFind.Rows[index].Cells[0].Value = jData.cEnabled;
                dataGridView1_CommentFind.Rows[index].Cells[1].Value = jData.cName;
                dataGridView1_CommentFind.Rows[index].Cells[2].Value = jData.cDesc;
            }
        }
        private void update_config()
        {
            app_options.folder_configData.jsonData.Clear();

            for (int i = 0; i < dataGridView1_Folder.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1_Folder.Rows[i];
                jsonData jData = new jsonData("","","");

                if (row.Cells[0].Value == null)
                    continue;

                jData.cEnabled = row.Cells[0].Value.ToString();
                jData.cName = (string)row.Cells[1].Value;
                jData.cDesc = (string)row.Cells[2].Value;

                app_options.folder_configData.jsonData.Add(jData);
            }



            app_options.file_configData.jsonData.Clear();

            for (int i = 0; i < dataGridView1_File.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1_File.Rows[i];
                if (row.Cells[0].Value == null)
                    continue;


                jsonData jData = new jsonData("", "", "");

                jData.cEnabled = row.Cells[0].Value.ToString();
                jData.cName = (string)row.Cells[1].Value;
                jData.cDesc = (string)row.Cells[2].Value;

                app_options.file_configData.jsonData.Add(jData);
            }

            app_options.comment_regexConfig.jsonData.Clear();

            for (int i = 0; i < dataGridView1_CommentRegex.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1_CommentRegex.Rows[i];
                if (row.Cells[0].Value == null)
                    continue;


                jsonData jData = new jsonData("", "", "");

                jData.cEnabled = row.Cells[0].Value.ToString();
                jData.cName = (string)row.Cells[1].Value;
                jData.cDesc = (string)row.Cells[2].Value;

                app_options.comment_regexConfig.jsonData.Add(jData);
            }


            app_options.comment_findConfig.jsonData.Clear();

            for (int i = 0; i < dataGridView1_CommentFind.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1_CommentFind.Rows[i];
                if (row.Cells[0].Value == null)
                    continue;


                jsonData jData = new jsonData("", "", "");

                jData.cEnabled = row.Cells[0].Value.ToString();
                jData.cName = (string)row.Cells[1].Value;
                jData.cDesc = (string)row.Cells[2].Value;

                app_options.comment_findConfig.jsonData.Add(jData);
            }
        }

        private void Button1_OK_Click(object sender, EventArgs e)
        {
            update_config();

            
            save_config();
            Close();
        }

        private void Button2_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Ignore_FolderName(bool enabled, string fname,string desc)
        {
            
            int index = dataGridView1_Folder.Rows.Add();
            dataGridView1_Folder.Rows[index].Cells[0].Value = enabled;
            dataGridView1_Folder.Rows[index].Cells[1].Value = fname;
            dataGridView1_Folder.Rows[index].Cells[2].Value = desc;
        }

        private void Add_Ignore_FileName(bool enabled,string fname, string desc)
        {
            
            int index = dataGridView1_File.Rows.Add();
            dataGridView1_File.Rows[index].Cells[0].Value = enabled;
            dataGridView1_File.Rows[index].Cells[1].Value = fname;
            dataGridView1_File.Rows[index].Cells[2].Value = desc;
        }

        private void Add_Comment_Regex(bool enabled, string fname, string desc)
        {
            
            int index = dataGridView1_CommentRegex.Rows.Add();
            dataGridView1_CommentRegex.Rows[index].Cells[0].Value = enabled;
            dataGridView1_CommentRegex.Rows[index].Cells[1].Value = fname;
            dataGridView1_CommentRegex.Rows[index].Cells[2].Value = desc;
        }


        private void Button_Reset_Click(object sender, EventArgs e)
        {
            
            DialogResult MsgBoxResult = MessageBox.Show("Confirm reset ignore files, your setting will lose.",
                        "ComentInsight",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.Yes)
            {
                dataGridView1_File.Rows.Clear();
                dataGridView1_Folder.Rows.Clear();

                reset_ignore();
            }
        }

        private void RadioButton1_bakpath1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2_bakpath.Text = ".";
        }

        private void RadioButton2_bakpath2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2_bakpath.Text.Length < 2)
            {
                textBox2_bakpath.Text = Application.StartupPath + "\\comment_backup";
            }
        }

        private void Button1_DiffToolPath_Click(object sender, EventArgs e)
        {
            string lsPath = "";

            
            

            if (comboBox1_Diff.SelectedIndex == 0)
                lsPath = "BComp.exe";
            else if (comboBox1_Diff.SelectedIndex == 1)
                lsPath = "WinMergeU.exe";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = lsPath;
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "Application|*.exe|All Files|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_DiffToolPath.Text = openFileDialog.FileName;
                app_options.DiffToolPath = textBox_DiffToolPath.Text;

                ConfigHelper.UpdateAppConfig("DiffToolPath", app_options.DiffToolPath);
            }
        }
    }
}
