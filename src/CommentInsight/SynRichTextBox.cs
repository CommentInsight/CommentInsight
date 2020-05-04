using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    class SynRichTextBox : System.Windows.Forms.RichTextBox
    {
        public SynRichTextBox Synchronized { get; set; }

        public const int WM_VSCROLL = 276;
        public const int WM_HSCROLL = 277;
        public const int WM_LINESCROLL = 0xb6;

        public const int WM_SETCURSOR = 32;
        public const int WM_MOUSEWHEEL = 522;
        public const int WM_MOUSEMOVE = 512;
        public const int WM_MOUSELEAVE = 675;
        public const int WM_MOUSELAST = 521;
        public const int WM_MOUSEHOVER = 673;
        public const int WM_MOUSEFIRST = 512;
        public const int WM_MOUSEACTIVATE = 33;


        public void BeginUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
        }

        public void EndUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            this.Invalidate();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int WM_SETREDRAW = 0x0b;

        protected override void WndProc(ref Message m)
        {
           if ( (m.Msg == WM_HSCROLL || (m.Msg == WM_LINESCROLL) ||
                m.Msg == WM_VSCROLL ||
                m.Msg == WM_SETCURSOR ||
                m.Msg == WM_MOUSEWHEEL ||
                m.Msg == WM_MOUSEMOVE ||
                m.Msg == WM_MOUSELEAVE ||
                m.Msg == WM_MOUSELAST ||
                m.Msg == WM_MOUSEHOVER ||
                m.Msg == WM_MOUSEFIRST ||
                m.Msg == WM_MOUSEACTIVATE))
                {
                if (Synchronized != null)
                {
                    Message msg = m;
                    msg.HWnd = Synchronized.Handle;

                    Synchronized.PubWndProc(ref msg);
                }
            }
            base.WndProc(ref m);
        }

        public void PubWndProc(ref System.Windows.Forms.Message msg)
        {
            base.WndProc(ref msg);
        }
    }
}
