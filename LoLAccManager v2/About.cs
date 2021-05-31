using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLAccManager_v2
{
    public partial class About : Form
    {
        private void AddDrag(Control Control)
        {
            Control.MouseDown += DragForm_MouseDown;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(base.Handle, 161, 2, 0);
            }
        }
        public About()
        {
            InitializeComponent();
            AddDrag(titlebarPanel);
            AddDrag(ico);
            AddDrag(titlebarText);
        }

        private void titlebarClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Don't remove this label. 
            System.Diagnostics.Process.Start("https://github.com/ricozyx");
        }
    }
}
