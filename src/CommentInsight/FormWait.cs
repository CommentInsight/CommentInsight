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
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
        }

        private void FormWait_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value == 100)
                progressBar1.Value = 1;
        }
        public void setTipstr(int tip)
        {
            if (tip == 0)
            {
                label1_tip.Text = "Searching source files...";
            }
            else
                label1_tip.Text = "Cleanning source files...";
        }
    }
}
