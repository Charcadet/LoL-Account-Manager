using NETCore.Encrypt;
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
    public partial class Lol : Form
    {

			string titleVer = "2.0.2";

		public static string XORCipher(string data, string key)
		{
			int dataLen = data.Length;
			int keyLen = key.Length;
			char[] output = new char[dataLen];

			for (int i = 0; i < dataLen; ++i)
			{
				output[i] = (char)(data[i] ^ key[i % keyLen]);
			}

			return new string(output);
		}

		public List<Account> accListing = new List<Account>();

		public BindingSource source = new BindingSource();
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

		public Lol()
        {
            InitializeComponent();

            titlebarText.Text = "LoL Account Manager " + titleVer;
			AddDrag(titlebarPanel);
			AddDrag(ico);
			AddDrag(titlebarText);
			accListing = Account.LoadAccounts();
			source.DataSource = accListing;
			accountGrid.DataSource = source;
			accountGrid.EnableHeadersVisualStyles = false;
			accountGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 40, 46, 72);
		}

		private void titlebarMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void titlebarClose_Click(object sender, EventArgs e)
        {
			System.Windows.Forms.Application.Exit();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
			Add addForm = new Add();
			addForm.ShowDialog();
		}

        private void copyBtn_Click(object sender, EventArgs e)
        {
			string aesKey = "YOURAESKEYHERE";
			string key = "YOURKEYHERE";
			string cipherAESKey = Lol.XORCipher(aesKey, key);
			string plainAESKey = Lol.XORCipher(cipherAESKey, key);
			Account account = accListing.ElementAt(accountGrid.CurrentCell.RowIndex);
			string copyUser = account.accountUsername;
			string copyPass = EncryptProvider.AESDecrypt(account.accountPassword, plainAESKey);
			Clipboard.SetDataObject(copyUser + ":" + copyPass);
		}

        private void aboutBtn_Click(object sender, EventArgs e)
        {
			About abtForm = new About();
			abtForm.ShowDialog();
        }
    }
}
