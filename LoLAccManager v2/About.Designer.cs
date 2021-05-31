
namespace LoLAccManager_v2
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.ico = new System.Windows.Forms.PictureBox();
            this.titlebarClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.titlebarText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.titlebarPanel.Location = new System.Drawing.Point(-1, -1);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(338, 39);
            this.titlebarPanel.TabIndex = 1;
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
            this.titlebarText.Size = new System.Drawing.Size(122, 22);
            this.titlebarText.TabIndex = 5;
            this.titlebarText.Text = "LoLAM | About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoLAccManager_v2.Properties.Resources.UWU;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 118);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // creditLabel
            // 
            this.creditLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.creditLabel.AutoSize = true;
            this.creditLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditLabel.Font = new System.Drawing.Font("Nunito Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.creditLabel.Location = new System.Drawing.Point(102, 318);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(128, 20);
            this.creditLabel.TabIndex = 3;
            this.creditLabel.TabStop = true;
            this.creditLabel.Text = "Made by Ricozyx";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creditLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.creditLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(6, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 119);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(336, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
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
        private System.Windows.Forms.PictureBox ico;
        private Bunifu.Framework.UI.BunifuImageButton titlebarClose;
        private Bunifu.Framework.UI.BunifuCustomLabel titlebarText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel creditLabel;
        private System.Windows.Forms.Label label1;
    }
}