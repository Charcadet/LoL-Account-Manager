using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using NETCore.Encrypt;

namespace LoLAccManager_v2
{

    public partial class Add : Form
    {
		public static class Global
		{
			public static JArray jArray = new JArray();
		}
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
		public Add()
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

		private void Save()
        {
			if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtIGN.Text))
			{
				return;
			}
			Lol form = new Lol();
			string aesKey = "YOURAESKEYHERE";
			string key = "YOURKEYHERE";
			string cipherAESKey = Lol.XORCipher(aesKey, key);
			string plainAESKey = Lol.XORCipher(cipherAESKey, key);
			string encryptedPass = EncryptProvider.AESEncrypt(txtPassword.Text, plainAESKey);
			string value = JsonConvert.SerializeObject(new Account
			{
				accountRegion = dropRegion.selectedValue.ToString(),
				accountUsername = txtUsername.Text,
				accountPassword = encryptedPass,
				accountIGN = txtIGN.Text,
				accountRank = string.Empty,
				accountWinrate = string.Empty
			}); ;
			string path = "accountData.json";
			
			using (StreamReader reader = File.OpenText(path))
			{
				using JsonTextReader reader2 = new JsonTextReader(reader);
				Global.jArray = (JArray)JToken.ReadFrom(reader2);
				Global.jArray.Add(value);
			}
			using (StreamWriter streamWriter = new StreamWriter(path, append: false))
			{
				streamWriter.WriteLine(Global.jArray.ToString());
				streamWriter.Close();
			}
			form.accListing = Account.LoadAccounts();
			form.source.DataSource = form.accListing;
			form.accountGrid.DataSource = form.source;
			form.accountGrid.Update();
			Application.Restart();
			this.Close();
		}

        private void saveBtn_Click(object sender, EventArgs e)
        {
			Save();
		}

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void titlebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlebarText_Click(object sender, EventArgs e)
        {

        }

        private void ico_Click(object sender, EventArgs e)
        {

        }
    }
}
