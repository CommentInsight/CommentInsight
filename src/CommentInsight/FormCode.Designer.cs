namespace CommentCleanTool
{
    partial class FormCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Pre = new System.Windows.Forms.Button();
            this.button2_Next = new System.Windows.Forms.Button();
            this.button3_Clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1_FileList = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3_Comment = new System.Windows.Forms.Label();
            this.richTextBox1 = new CommentCleanTool.SynRichTextBox();
            this.richTextBox2 = new CommentCleanTool.SynRichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_Compare = new System.Windows.Forms.Button();
            this.radioButton1_all = new System.Windows.Forms.RadioButton();
            this.radioButton2_notAscii = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_CommentOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // button1_Pre
            // 
            this.button1_Pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1_Pre.Location = new System.Drawing.Point(4, 596);
            this.button1_Pre.Margin = new System.Windows.Forms.Padding(2);
            this.button1_Pre.Name = "button1_Pre";
            this.button1_Pre.Size = new System.Drawing.Size(74, 24);
            this.button1_Pre.TabIndex = 2;
            this.button1_Pre.Text = "&< Pre";
            this.button1_Pre.UseVisualStyleBackColor = true;
            this.button1_Pre.Click += new System.EventHandler(this.button1_Pre_Click);
            // 
            // button2_Next
            // 
            this.button2_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2_Next.Location = new System.Drawing.Point(84, 596);
            this.button2_Next.Margin = new System.Windows.Forms.Padding(2);
            this.button2_Next.Name = "button2_Next";
            this.button2_Next.Size = new System.Drawing.Size(74, 24);
            this.button2_Next.TabIndex = 3;
            this.button2_Next.Text = "Next &>";
            this.button2_Next.UseVisualStyleBackColor = true;
            this.button2_Next.Click += new System.EventHandler(this.button2_Next_Click);
            // 
            // button3_Clear
            // 
            this.button3_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3_Clear.Location = new System.Drawing.Point(486, 593);
            this.button3_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button3_Clear.Name = "button3_Clear";
            this.button3_Clear.Size = new System.Drawing.Size(100, 30);
            this.button3_Clear.TabIndex = 7;
            this.button3_Clear.Text = "&Reset";
            this.button3_Clear.UseVisualStyleBackColor = true;
            this.button3_Clear.Visible = false;
            this.button3_Clear.Click += new System.EventHandler(this.button3_Clear_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(4, 593);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "&Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboBox1_FileList
            // 
            this.comboBox1_FileList.Enabled = false;
            this.comboBox1_FileList.FormattingEnabled = true;
            this.comboBox1_FileList.Location = new System.Drawing.Point(48, 13);
            this.comboBox1_FileList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1_FileList.Name = "comboBox1_FileList";
            this.comboBox1_FileList.Size = new System.Drawing.Size(545, 20);
            this.comboBox1_FileList.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 670);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3_Comment);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button2_Next);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button1_Pre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.button1_Compare);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3_Clear);
            this.splitContainer1.Size = new System.Drawing.Size(1177, 630);
            this.splitContainer1.SplitterDistance = 582;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 11;
            // 
            // label3_Comment
            // 
            this.label3_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_Comment.AutoSize = true;
            this.label3_Comment.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3_Comment.Location = new System.Drawing.Point(558, 602);
            this.label3_Comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_Comment.Name = "label3_Comment";
            this.label3_Comment.Size = new System.Drawing.Size(12, 12);
            this.label3_Comment.TabIndex = 13;
            this.label3_Comment.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 586);
            this.richTextBox1.Synchronized = this.richTextBox2;
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.DetectUrls = false;
            this.richTextBox2.Location = new System.Drawing.Point(4, 2);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(590, 586);
            this.richTextBox2.Synchronized = this.richTextBox1;
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 602);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Comment Removed:";
            // 
            // button1_Compare
            // 
            this.button1_Compare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1_Compare.Location = new System.Drawing.Point(122, 593);
            this.button1_Compare.Margin = new System.Windows.Forms.Padding(2);
            this.button1_Compare.Name = "button1_Compare";
            this.button1_Compare.Size = new System.Drawing.Size(143, 30);
            this.button1_Compare.TabIndex = 8;
            this.button1_Compare.Text = "&Compare";
            this.button1_Compare.UseVisualStyleBackColor = true;
            this.button1_Compare.Visible = false;
            this.button1_Compare.Click += new System.EventHandler(this.Button1_Compare_Click);
            // 
            // radioButton1_all
            // 
            this.radioButton1_all.AutoSize = true;
            this.radioButton1_all.Checked = true;
            this.radioButton1_all.Location = new System.Drawing.Point(710, 13);
            this.radioButton1_all.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1_all.Name = "radioButton1_all";
            this.radioButton1_all.Size = new System.Drawing.Size(41, 16);
            this.radioButton1_all.TabIndex = 14;
            this.radioButton1_all.TabStop = true;
            this.radioButton1_all.Text = "&All";
            this.radioButton1_all.UseVisualStyleBackColor = true;
            this.radioButton1_all.CheckedChanged += new System.EventHandler(this.radioButton1_all_CheckedChanged);
            // 
            // radioButton2_notAscii
            // 
            this.radioButton2_notAscii.AutoSize = true;
            this.radioButton2_notAscii.Location = new System.Drawing.Point(766, 13);
            this.radioButton2_notAscii.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2_notAscii.Name = "radioButton2_notAscii";
            this.radioButton2_notAscii.Size = new System.Drawing.Size(113, 16);
            this.radioButton2_notAscii.TabIndex = 15;
            this.radioButton2_notAscii.Text = "&Regex Config...";
            this.radioButton2_notAscii.UseVisualStyleBackColor = true;
            this.radioButton2_notAscii.CheckedChanged += new System.EventHandler(this.radioButton2_notAscii_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Comment Search:";
            // 
            // button1_CommentOptions
            // 
            this.button1_CommentOptions.Location = new System.Drawing.Point(895, 5);
            this.button1_CommentOptions.Name = "button1_CommentOptions";
            this.button1_CommentOptions.Size = new System.Drawing.Size(123, 30);
            this.button1_CommentOptions.TabIndex = 16;
            this.button1_CommentOptions.Text = "Comment Options";
            this.button1_CommentOptions.UseVisualStyleBackColor = true;
            this.button1_CommentOptions.Click += new System.EventHandler(this.Button1_CommentOptions_Click);
            // 
            // FormCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1198, 670);
            this.Controls.Add(this.button1_CommentOptions);
            this.Controls.Add(this.radioButton2_notAscii);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.radioButton1_all);
            this.Controls.Add(this.comboBox1_FileList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCode";
            this.Load += new System.EventHandler(this.FormCode_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCode_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Pre;
        private System.Windows.Forms.Button button2_Next;
        private System.Windows.Forms.Button button3_Clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1_FileList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_Comment;
        private System.Windows.Forms.RadioButton radioButton1_all;
        private System.Windows.Forms.RadioButton radioButton2_notAscii;
        private SynRichTextBox richTextBox1;
        private SynRichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_Compare;
        private System.Windows.Forms.Button button1_CommentOptions;
    }
}