
namespace LoLAccManager_v2
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.ico = new System.Windows.Forms.PictureBox();
            this.titlebarClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.titlebarText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelIGN = new System.Windows.Forms.Label();
            this.txtIGN = new System.Windows.Forms.TextBox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropRegion = new Bunifu.Framework.UI.BunifuDropdown();
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.titlebarPanel.Controls.Add(this.ico);
            this.titlebarPanel.Controls.Add(this.titlebarClose);
            this.titlebarPanel.Controls.Add(this.titlebarText);
            this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(338, 39);
            this.titlebarPanel.TabIndex = 0;
            this.titlebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlebarPanel_Paint);
            // 
            // ico
            // 
            this.ico.BackgroundImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ico.ErrorImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.InitialImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.Location = new System.Drawing.Point(4, 1);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(37, 38);
            this.ico.TabIndex = 6;
            this.ico.TabStop = false;
            this.ico.Click += new System.EventHandler(this.ico_Click);
            // 
            // titlebarClose
            // 
            this.titlebarClose.BackColor = System.Drawing.Color.Transparent;
            this.titlebarClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titlebarClose.Image = global::LoLAccManager_v2.Properties.Resources.close;
            this.titlebarClose.ImageActive = null;
            this.titlebarClose.Location = new System.Drawing.Point(307, 3);
            this.titlebarClose.Name = "titlebarClose";
            this.titlebarClose.Size = new System.Drawing.Size(28, 33);
            this.titlebarClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarClose.TabIndex = 3;
            this.titlebarClose.TabStop = false;
            this.titlebarClose.Zoom = 10;
            this.titlebarClose.Click += new System.EventHandler(this.titlebarClose_Click);
            // 
            // titlebarText
            // 
            this.titlebarText.AutoSize = true;
            this.titlebarText.BackColor = System.Drawing.Color.Transparent;
            this.titlebarText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebarText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.titlebarText.Location = new System.Drawing.Point(45, 9);
            this.titlebarText.Name = "titlebarText";
            this.titlebarText.Size = new System.Drawing.Size(170, 22);
            this.titlebarText.TabIndex = 5;
            this.titlebarText.Text = "LoLAM | Add account";
            this.titlebarText.Click += new System.EventHandler(this.titlebarText_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoLAccManager_v2.Properties.Resources.raiseyouracc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 148);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegion.Location = new System.Drawing.Point(32, 240);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(44, 15);
            this.labelRegion.TabIndex = 3;
            this.labelRegion.Text = "Region:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(32, 292);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 15);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(35, 310);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(263, 24);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Location = new System.Drawing.Point(32, 349);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 15);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(35, 367);
            this.txtPassword.MaxLength = 90;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(263, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // labelIGN
            // 
            this.labelIGN.AutoSize = true;
            this.labelIGN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIGN.Location = new System.Drawing.Point(32, 405);
            this.labelIGN.Name = "labelIGN";
            this.labelIGN.Size = new System.Drawing.Size(93, 15);
            this.labelIGN.TabIndex = 10;
            this.labelIGN.Text = "Summoner name:";
            // 
            // txtIGN
            // 
            this.txtIGN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.txtIGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIGN.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGN.ForeColor = System.Drawing.Color.White;
            this.txtIGN.Location = new System.Drawing.Point(35, 423);
            this.txtIGN.MaxLength = 22;
            this.txtIGN.Name = "txtIGN";
            this.txtIGN.Size = new System.Drawing.Size(263, 24);
            this.txtIGN.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.BorderRadius = 2;
            this.saveBtn.ButtonText = "Add account";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveBtn.Font = new System.Drawing.Font("Nunito Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveBtn.Iconimage = global::LoLAccManager_v2.Properties.Resources.accadd;
            this.saveBtn.Iconimage_right = null;
            this.saveBtn.Iconimage_right_Selected = null;
            this.saveBtn.Iconimage_Selected = null;
            this.saveBtn.IconMarginLeft = 0;
            this.saveBtn.IconMarginRight = 0;
            this.saveBtn.IconRightVisible = true;
            this.saveBtn.IconRightZoom = 0D;
            this.saveBtn.IconVisible = true;
            this.saveBtn.IconZoom = 90D;
            this.saveBtn.IsTab = false;
            this.saveBtn.Location = new System.Drawing.Point(73, 478);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.saveBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(180, 48);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Add account";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Nunito SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dropRegion
            // 
            this.dropRegion.BackColor = System.Drawing.Color.Transparent;
            this.dropRegion.BorderRadius = 3;
            this.dropRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.dropRegion.Items = new string[] {
        "EUW",
        "EUNE",
        "NA",
        "BR",
        "LAN",
        "LAS",
        "OCE",
        "RU",
        "TR"};
            this.dropRegion.Location = new System.Drawing.Point(28, 258);
            this.dropRegion.Name = "dropRegion";
            this.dropRegion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.dropRegion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.dropRegion.selectedIndex = -1;
            this.dropRegion.Size = new System.Drawing.Size(272, 23);
            this.dropRegion.TabIndex = 12;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(336, 565);
            this.Controls.Add(this.dropRegion);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.labelIGN);
            this.Controls.Add(this.txtIGN);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlebarPanel;
        private Bunifu.Framework.UI.BunifuImageButton titlebarClose;
        private System.Windows.Forms.PictureBox ico;
        private Bunifu.Framework.UI.BunifuCustomLabel titlebarText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelIGN;
        private System.Windows.Forms.TextBox txtIGN;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private Bunifu.Framework.UI.BunifuDropdown dropRegion;
    }
}