namespace CommentCleanTool
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_Folder = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_File = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_CommentRegex = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_CommentFind = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1_Diff = new System.Windows.Forms.ComboBox();
            this.button1_DiffToolPath = new System.Windows.Forms.Button();
            this.textBox_DiffToolPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2_bakpath2 = new System.Windows.Forms.RadioButton();
            this.textBox_FileExt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1_bakpath1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2_bakpath = new System.Windows.Forms.TextBox();
            this.button1_OK = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Folder)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_File)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CommentRegex)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CommentFind)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ignore Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1_Folder);
            this.groupBox4.Location = new System.Drawing.Point(21, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 159);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ignore folders";
            // 
            // dataGridView1_Folder
            // 
            this.dataGridView1_Folder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Folder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView1_Folder.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1_Folder.Name = "dataGridView1_Folder";
            this.dataGridView1_Folder.RowTemplate.Height = 23;
            this.dataGridView1_Folder.Size = new System.Drawing.Size(768, 133);
            this.dataGridView1_Folder.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Enabled";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Folder Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Desc";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 300;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1_File);
            this.groupBox3.Location = new System.Drawing.Point(21, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ignore files";
            // 
            // dataGridView1_File
            // 
            this.dataGridView1_File.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_File.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1_File.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1_File.Name = "dataGridView1_File";
            this.dataGridView1_File.RowTemplate.Height = 23;
            this.dataGridView1_File.Size = new System.Drawing.Size(768, 133);
            this.dataGridView1_File.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Enabled";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "File Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comment Regex";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1_CommentRegex);
            this.groupBox6.Location = new System.Drawing.Point(21, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(780, 159);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Comments by Regex:";
            // 
            // dataGridView1_CommentRegex
            // 
            this.dataGridView1_CommentRegex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_CommentRegex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1_CommentRegex.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1_CommentRegex.Name = "dataGridView1_CommentRegex";
            this.dataGridView1_CommentRegex.RowTemplate.Height = 23;
            this.dataGridView1_CommentRegex.Size = new System.Drawing.Size(768, 133);
            this.dataGridView1_CommentRegex.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Enabled";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Regex";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1_CommentFind);
            this.groupBox5.Location = new System.Drawing.Point(21, 196);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(780, 159);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Comments by sub-string";
            // 
            // dataGridView1_CommentFind
            // 
            this.dataGridView1_CommentFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_CommentFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1_CommentFind.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1_CommentFind.Name = "dataGridView1_CommentFind";
            this.dataGridView1_CommentFind.RowTemplate.Height = 23;
            this.dataGridView1_CommentFind.Size = new System.Drawing.Size(768, 133);
            this.dataGridView1_CommentFind.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "Enabled";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Find-String";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1_Diff);
            this.groupBox2.Controls.Add(this.button1_DiffToolPath);
            this.groupBox2.Controls.Add(this.textBox_DiffToolPath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Diff Tool";
            // 
            // comboBox1_Diff
            // 
            this.comboBox1_Diff.FormattingEnabled = true;
            this.comboBox1_Diff.Items.AddRange(new object[] {
            "Beyond Compare",
            "WinMege",
            "Custom..."});
            this.comboBox1_Diff.Location = new System.Drawing.Point(153, 38);
            this.comboBox1_Diff.Name = "comboBox1_Diff";
            this.comboBox1_Diff.Size = new System.Drawing.Size(121, 20);
            this.comboBox1_Diff.TabIndex = 4;
            this.comboBox1_Diff.Text = "Beyond Compare";
            // 
            // button1_DiffToolPath
            // 
            this.button1_DiffToolPath.Location = new System.Drawing.Point(292, 36);
            this.button1_DiffToolPath.Name = "button1_DiffToolPath";
            this.button1_DiffToolPath.Size = new System.Drawing.Size(58, 23);
            this.button1_DiffToolPath.TabIndex = 2;
            this.button1_DiffToolPath.Text = "...";
            this.button1_DiffToolPath.UseVisualStyleBackColor = true;
            this.button1_DiffToolPath.Click += new System.EventHandler(this.Button1_DiffToolPath_Click);
            // 
            // textBox_DiffToolPath
            // 
            this.textBox_DiffToolPath.Location = new System.Drawing.Point(153, 83);
            this.textBox_DiffToolPath.Name = "textBox_DiffToolPath";
            this.textBox_DiffToolPath.Size = new System.Drawing.Size(536, 21);
            this.textBox_DiffToolPath.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Diff Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Diff Tool:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2_bakpath2);
            this.groupBox1.Controls.Add(this.textBox_FileExt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton1_bakpath1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2_bakpath);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Source File";
            // 
            // radioButton2_bakpath2
            // 
            this.radioButton2_bakpath2.AutoSize = true;
            this.radioButton2_bakpath2.Location = new System.Drawing.Point(153, 94);
            this.radioButton2_bakpath2.Name = "radioButton2_bakpath2";
            this.radioButton2_bakpath2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2_bakpath2.TabIndex = 5;
            this.radioButton2_bakpath2.Text = "Coustom Path";
            this.radioButton2_bakpath2.UseVisualStyleBackColor = true;
            this.radioButton2_bakpath2.CheckedChanged += new System.EventHandler(this.RadioButton2_bakpath2_CheckedChanged);
            // 
            // textBox_FileExt
            // 
            this.textBox_FileExt.Location = new System.Drawing.Point(152, 33);
            this.textBox_FileExt.Name = "textBox_FileExt";
            this.textBox_FileExt.Size = new System.Drawing.Size(537, 21);
            this.textBox_FileExt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "File ext:";
            // 
            // radioButton1_bakpath1
            // 
            this.radioButton1_bakpath1.AutoSize = true;
            this.radioButton1_bakpath1.Checked = true;
            this.radioButton1_bakpath1.Location = new System.Drawing.Point(153, 64);
            this.radioButton1_bakpath1.Name = "radioButton1_bakpath1";
            this.radioButton1_bakpath1.Size = new System.Drawing.Size(197, 16);
            this.radioButton1_bakpath1.TabIndex = 4;
            this.radioButton1_bakpath1.TabStop = true;
            this.radioButton1_bakpath1.Text = "Same with sourcecode filepath";
            this.radioButton1_bakpath1.UseVisualStyleBackColor = true;
            this.radioButton1_bakpath1.CheckedChanged += new System.EventHandler(this.RadioButton1_bakpath1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Backup To:";
            // 
            // textBox2_bakpath
            // 
            this.textBox2_bakpath.Location = new System.Drawing.Point(263, 92);
            this.textBox2_bakpath.Name = "textBox2_bakpath";
            this.textBox2_bakpath.Size = new System.Drawing.Size(426, 21);
            this.textBox2_bakpath.TabIndex = 3;
            this.textBox2_bakpath.Text = ".";
            // 
            // button1_OK
            // 
            this.button1_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1_OK.Location = new System.Drawing.Point(633, 424);
            this.button1_OK.Name = "button1_OK";
            this.button1_OK.Size = new System.Drawing.Size(93, 32);
            this.button1_OK.TabIndex = 1;
            this.button1_OK.Text = "OK";
            this.button1_OK.UseVisualStyleBackColor = true;
            this.button1_OK.Click += new System.EventHandler(this.Button1_OK_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(750, 424);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(93, 32);
            this.button2_Cancel.TabIndex = 1;
            this.button2_Cancel.Text = "Cancel";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.Button2_Cancel_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(37, 424);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(154, 31);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "Reset Ignore setting";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 467);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_OK);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Folder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_File)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CommentRegex)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CommentFind)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1_OK;
        private System.Windows.Forms.Button button2_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2_bakpath2;
        private System.Windows.Forms.TextBox textBox_FileExt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1_bakpath1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2_bakpath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1_Diff;
        private System.Windows.Forms.Button button1_DiffToolPath;
        private System.Windows.Forms.TextBox textBox_DiffToolPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1_Folder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1_File;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_CommentRegex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1_CommentFind;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}