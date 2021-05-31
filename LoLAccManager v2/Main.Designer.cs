
namespace LoLAccManager_v2
{
    partial class Lol
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lol));
            this.fontsInstaller1 = new WK.Libraries.FontsInstallerNS.FontsInstaller(this.components);
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.ico = new System.Windows.Forms.PictureBox();
            this.titlebarMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.titlebarClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.titlebarText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountGrid = new System.Windows.Forms.DataGridView();
            this.accountRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountWinrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.copyBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.aboutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontsInstaller1
            // 
            this.fontsInstaller1.AutoInstall = true;
            this.fontsInstaller1.AutoRestart = true;
            this.fontsInstaller1.ContainerControl = this;
            this.fontsInstaller1.CustomInstallerDialog = null;
            this.fontsInstaller1.DialogOptions.CollapsedContent = "{Fonts}";
            this.fontsInstaller1.DialogOptions.Content = "In order for LoL Account Manager to function properly, {FontsRequiredExpression} " +
    "to be installed in your system before proceeding. To view {FontsExpression}, cli" +
    "ck \"See details\".";
            this.fontsInstaller1.DialogOptions.CustomIcon = "D:\\Downloads\\LoLAccManagerv2.ico";
            this.fontsInstaller1.DialogOptions.ShowAppIcon = true;
            this.fontsInstaller1.DialogOptions.ShowCancelButton = false;
            this.fontsInstaller1.DialogOptions.Title = "Fonts installation required";
            this.fontsInstaller1.DialogOptions.UseElevationIcon = false;
            this.fontsInstaller1.DialogOptions.WindowTitle = "LoL Account Manager v2.0.1";
            this.fontsInstaller1.Fonts.Add(((WK.Libraries.FontsInstallerNS.Models.UserFont)(resources.GetObject("fontsInstaller1.Fonts"))));
            this.fontsInstaller1.Fonts.Add(((WK.Libraries.FontsInstallerNS.Models.UserFont)(resources.GetObject("fontsInstaller1.Fonts1"))));
            this.fontsInstaller1.Fonts.Add(((WK.Libraries.FontsInstallerNS.Models.UserFont)(resources.GetObject("fontsInstaller1.Fonts2"))));
            this.fontsInstaller1.Fonts.Add(((WK.Libraries.FontsInstallerNS.Models.UserFont)(resources.GetObject("fontsInstaller1.Fonts3"))));
            this.fontsInstaller1.FontsListBullet = "+";
            this.fontsInstaller1.ParentForm = this;
            this.fontsInstaller1.TestingMode = false;
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.titlebarPanel.Controls.Add(this.ico);
            this.titlebarPanel.Controls.Add(this.titlebarMin);
            this.titlebarPanel.Controls.Add(this.titlebarClose);
            this.titlebarPanel.Controls.Add(this.titlebarText);
            this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(801, 39);
            this.titlebarPanel.TabIndex = 0;
            // 
            // ico
            // 
            this.ico.BackgroundImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ico.ErrorImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.InitialImage = global::LoLAccManager_v2.Properties.Resources.LoLAccManagerv2;
            this.ico.Location = new System.Drawing.Point(5, 1);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(37, 38);
            this.ico.TabIndex = 4;
            this.ico.TabStop = false;
            // 
            // titlebarMin
            // 
            this.titlebarMin.BackColor = System.Drawing.Color.Transparent;
            this.titlebarMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titlebarMin.Image = global::LoLAccManager_v2.Properties.Resources.minim;
            this.titlebarMin.ImageActive = null;
            this.titlebarMin.Location = new System.Drawing.Point(736, 3);
            this.titlebarMin.Name = "titlebarMin";
            this.titlebarMin.Size = new System.Drawing.Size(28, 33);
            this.titlebarMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarMin.TabIndex = 3;
            this.titlebarMin.TabStop = false;
            this.titlebarMin.Zoom = 10;
            this.titlebarMin.Click += new System.EventHandler(this.titlebarMin_Click);
            // 
            // titlebarClose
            // 
            this.titlebarClose.BackColor = System.Drawing.Color.Transparent;
            this.titlebarClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titlebarClose.Image = global::LoLAccManager_v2.Properties.Resources.close;
            this.titlebarClose.ImageActive = null;
            this.titlebarClose.Location = new System.Drawing.Point(770, 3);
            this.titlebarClose.Name = "titlebarClose";
            this.titlebarClose.Size = new System.Drawing.Size(28, 33);
            this.titlebarClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarClose.TabIndex = 2;
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
            this.titlebarText.Location = new System.Drawing.Point(46, 9);
            this.titlebarText.Name = "titlebarText";
            this.titlebarText.Size = new System.Drawing.Size(172, 22);
            this.titlebarText.TabIndex = 1;
            this.titlebarText.Text = "LoL Account Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(215, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 484);
            this.panel1.TabIndex = 0;
            // 
            // accountGrid
            // 
            this.accountGrid.AllowUserToAddRows = false;
            this.accountGrid.AllowUserToDeleteRows = false;
            this.accountGrid.AllowUserToResizeColumns = false;
            this.accountGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accountGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.accountGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.accountGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.accountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountRegion,
            this.AccountUsername,
            this.accountPassword,
            this.accountIGN,
            this.accountRank,
            this.accountWinrate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.accountGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accountGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.accountGrid.Location = new System.Drawing.Point(219, 0);
            this.accountGrid.Name = "accountGrid";
            this.accountGrid.ReadOnly = true;
            this.accountGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nunito", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.accountGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            this.accountGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.accountGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.accountGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.accountGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.accountGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.accountGrid.Size = new System.Drawing.Size(592, 480);
            this.accountGrid.TabIndex = 1;
            this.accountGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountRegion
            // 
            this.accountRegion.DataPropertyName = "accountRegion";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.accountRegion.DefaultCellStyle = dataGridViewCellStyle3;
            this.accountRegion.FillWeight = 80F;
            this.accountRegion.HeaderText = "Region";
            this.accountRegion.MaxInputLength = 8;
            this.accountRegion.Name = "accountRegion";
            this.accountRegion.ReadOnly = true;
            this.accountRegion.Width = 80;
            // 
            // AccountUsername
            // 
            this.AccountUsername.DataPropertyName = "accountUsername";
            this.AccountUsername.HeaderText = "Username";
            this.AccountUsername.Name = "AccountUsername";
            this.AccountUsername.ReadOnly = true;
            this.AccountUsername.Width = 110;
            // 
            // accountPassword
            // 
            this.accountPassword.DataPropertyName = "accountPassword";
            this.accountPassword.HeaderText = "Password";
            this.accountPassword.Name = "accountPassword";
            this.accountPassword.ReadOnly = true;
            this.accountPassword.Visible = false;
            // 
            // accountIGN
            // 
            this.accountIGN.DataPropertyName = "accountIGN";
            this.accountIGN.HeaderText = "IGN";
            this.accountIGN.Name = "accountIGN";
            this.accountIGN.ReadOnly = true;
            this.accountIGN.Width = 110;
            // 
            // accountRank
            // 
            this.accountRank.DataPropertyName = "accountRank";
            this.accountRank.HeaderText = "Rank";
            this.accountRank.Name = "accountRank";
            this.accountRank.ReadOnly = true;
            this.accountRank.Width = 140;
            // 
            // accountWinrate
            // 
            this.accountWinrate.DataPropertyName = "accountWinrate";
            this.accountWinrate.HeaderText = "Winrate";
            this.accountWinrate.Name = "accountWinrate";
            this.accountWinrate.ReadOnly = true;
            this.accountWinrate.Width = 110;
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 2;
            this.addBtn.ButtonText = "Add account";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Font = new System.Drawing.Font("Nunito Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = global::LoLAccManager_v2.Properties.Resources.accadd;
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 0;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 90D;
            this.addBtn.IsTab = false;
            this.addBtn.Location = new System.Drawing.Point(19, 9);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(180, 48);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add account";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Textcolor = System.Drawing.Color.White;
            this.addBtn.TextFont = new System.Drawing.Font("Nunito SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.copyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyBtn.BorderRadius = 2;
            this.copyBtn.ButtonText = "Copy account login";
            this.copyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyBtn.DisabledColor = System.Drawing.Color.Gray;
            this.copyBtn.Font = new System.Drawing.Font("Nunito Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.copyBtn.Iconimage = global::LoLAccManager_v2.Properties.Resources.copyacc;
            this.copyBtn.Iconimage_right = null;
            this.copyBtn.Iconimage_right_Selected = null;
            this.copyBtn.Iconimage_Selected = null;
            this.copyBtn.IconMarginLeft = 0;
            this.copyBtn.IconMarginRight = 0;
            this.copyBtn.IconRightVisible = true;
            this.copyBtn.IconRightZoom = 0D;
            this.copyBtn.IconVisible = true;
            this.copyBtn.IconZoom = 90D;
            this.copyBtn.IsTab = false;
            this.copyBtn.Location = new System.Drawing.Point(19, 63);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.copyBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.copyBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.copyBtn.selected = false;
            this.copyBtn.Size = new System.Drawing.Size(180, 48);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.Text = "Copy account login";
            this.copyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBtn.Textcolor = System.Drawing.Color.White;
            this.copyBtn.TextFont = new System.Drawing.Font("Nunito SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutBtn.BorderRadius = 2;
            this.aboutBtn.ButtonText = "About LoLAM";
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.aboutBtn.Font = new System.Drawing.Font("Nunito Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutBtn.Iconimage = global::LoLAccManager_v2.Properties.Resources.aboutbtn;
            this.aboutBtn.Iconimage_right = null;
            this.aboutBtn.Iconimage_right_Selected = null;
            this.aboutBtn.Iconimage_Selected = null;
            this.aboutBtn.IconMarginLeft = 0;
            this.aboutBtn.IconMarginRight = 0;
            this.aboutBtn.IconRightVisible = true;
            this.aboutBtn.IconRightZoom = 0D;
            this.aboutBtn.IconVisible = true;
            this.aboutBtn.IconZoom = 90D;
            this.aboutBtn.IsTab = false;
            this.aboutBtn.Location = new System.Drawing.Point(19, 420);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.aboutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.aboutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.aboutBtn.selected = false;
            this.aboutBtn.Size = new System.Drawing.Size(180, 48);
            this.aboutBtn.TabIndex = 4;
            this.aboutBtn.Text = "About LoLAM";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.Textcolor = System.Drawing.Color.White;
            this.aboutBtn.TextFont = new System.Drawing.Font("Nunito SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.aboutBtn);
            this.panel2.Controls.Add(this.copyBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.accountGrid);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 483);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lol
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL Account Manager";
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WK.Libraries.FontsInstallerNS.FontsInstaller fontsInstaller1;
        private System.Windows.Forms.Panel titlebarPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel titlebarText;
        private Bunifu.Framework.UI.BunifuImageButton titlebarClose;
        private Bunifu.Framework.UI.BunifuImageButton titlebarMin;
        private System.Windows.Forms.PictureBox ico;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton aboutBtn;
        private Bunifu.Framework.UI.BunifuFlatButton copyBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
        public System.Windows.Forms.DataGridView accountGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountWinrate;
    }
}

