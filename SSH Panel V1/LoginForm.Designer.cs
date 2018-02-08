namespace SSH_Panel_V1
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGridSavedUsers = new System.Windows.Forms.DataGridView();
            this.btnSaveUserConfig = new System.Windows.Forms.Button();
            this.btnSshLogin = new System.Windows.Forms.Button();
            this.btnLoadUserConfig = new System.Windows.Forms.Button();
            this.lblLoginPortText = new System.Windows.Forms.Label();
            this.lblLoginHostText = new System.Windows.Forms.Label();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.lblLoginPassText = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblServerAddressText = new System.Windows.Forms.Label();
            this.txtBoxServeraddress = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlBackgroundImage = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSavedUsers)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dGridSavedUsers);
            this.panel1.Controls.Add(this.btnSaveUserConfig);
            this.panel1.Controls.Add(this.btnSshLogin);
            this.panel1.Controls.Add(this.btnLoadUserConfig);
            this.panel1.Controls.Add(this.lblLoginPortText);
            this.panel1.Controls.Add(this.lblLoginHostText);
            this.panel1.Controls.Add(this.lblLoginText);
            this.panel1.Controls.Add(this.lblLoginPassText);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.lblServerAddressText);
            this.panel1.Controls.Add(this.txtBoxServeraddress);
            this.panel1.Controls.Add(this.txtBoxPort);
            this.panel1.Controls.Add(this.txtBoxHost);
            this.panel1.Location = new System.Drawing.Point(33, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 291);
            this.panel1.TabIndex = 0;
            // 
            // dGridSavedUsers
            // 
            this.dGridSavedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSavedUsers.Location = new System.Drawing.Point(292, 73);
            this.dGridSavedUsers.Name = "dGridSavedUsers";
            this.dGridSavedUsers.Size = new System.Drawing.Size(203, 169);
            this.dGridSavedUsers.TabIndex = 6;
            // 
            // btnSaveUserConfig
            // 
            this.btnSaveUserConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnSaveUserConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveUserConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUserConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUserConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveUserConfig.Location = new System.Drawing.Point(396, 248);
            this.btnSaveUserConfig.Name = "btnSaveUserConfig";
            this.btnSaveUserConfig.Size = new System.Drawing.Size(99, 33);
            this.btnSaveUserConfig.TabIndex = 8;
            this.btnSaveUserConfig.Text = "Save";
            this.btnSaveUserConfig.UseVisualStyleBackColor = false;
            this.btnSaveUserConfig.Click += new System.EventHandler(this.btnSaveUserConfig_Click);
            // 
            // btnSshLogin
            // 
            this.btnSshLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnSshLogin.FlatAppearance.BorderSize = 0;
            this.btnSshLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSshLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSshLogin.ForeColor = System.Drawing.Color.White;
            this.btnSshLogin.Location = new System.Drawing.Point(12, 248);
            this.btnSshLogin.Name = "btnSshLogin";
            this.btnSshLogin.Size = new System.Drawing.Size(99, 33);
            this.btnSshLogin.TabIndex = 5;
            this.btnSshLogin.Text = "Login";
            this.btnSshLogin.UseVisualStyleBackColor = false;
            this.btnSshLogin.Click += new System.EventHandler(this.btnSshLogin_Click);
            // 
            // btnLoadUserConfig
            // 
            this.btnLoadUserConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnLoadUserConfig.FlatAppearance.BorderSize = 0;
            this.btnLoadUserConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadUserConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUserConfig.ForeColor = System.Drawing.Color.White;
            this.btnLoadUserConfig.Location = new System.Drawing.Point(292, 248);
            this.btnLoadUserConfig.Name = "btnLoadUserConfig";
            this.btnLoadUserConfig.Size = new System.Drawing.Size(98, 33);
            this.btnLoadUserConfig.TabIndex = 7;
            this.btnLoadUserConfig.Text = "Load";
            this.btnLoadUserConfig.UseVisualStyleBackColor = false;
            this.btnLoadUserConfig.Click += new System.EventHandler(this.btnLoadUserConfig_Click);
            // 
            // lblLoginPortText
            // 
            this.lblLoginPortText.AutoSize = true;
            this.lblLoginPortText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPortText.Location = new System.Drawing.Point(240, 57);
            this.lblLoginPortText.Name = "lblLoginPortText";
            this.lblLoginPortText.Size = new System.Drawing.Size(32, 13);
            this.lblLoginPortText.TabIndex = 9;
            this.lblLoginPortText.Text = "Poort";
            // 
            // lblLoginHostText
            // 
            this.lblLoginHostText.AutoSize = true;
            this.lblLoginHostText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHostText.Location = new System.Drawing.Point(9, 57);
            this.lblLoginHostText.Name = "lblLoginHostText";
            this.lblLoginHostText.Size = new System.Drawing.Size(29, 13);
            this.lblLoginHostText.TabIndex = 10;
            this.lblLoginHostText.Text = "Host";
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblLoginText.Location = new System.Drawing.Point(5, 10);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(101, 37);
            this.lblLoginText.TabIndex = 14;
            this.lblLoginText.Text = "Login";
            // 
            // lblLoginPassText
            // 
            this.lblLoginPassText.AutoSize = true;
            this.lblLoginPassText.Location = new System.Drawing.Point(9, 177);
            this.lblLoginPassText.Name = "lblLoginPassText";
            this.lblLoginPassText.Size = new System.Drawing.Size(68, 13);
            this.lblLoginPassText.TabIndex = 11;
            this.lblLoginPassText.Text = "Wachtwoord";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(12, 193);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(266, 29);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // lblServerAddressText
            // 
            this.lblServerAddressText.AutoSize = true;
            this.lblServerAddressText.Location = new System.Drawing.Point(9, 117);
            this.lblServerAddressText.Name = "lblServerAddressText";
            this.lblServerAddressText.Size = new System.Drawing.Size(77, 13);
            this.lblServerAddressText.TabIndex = 12;
            this.lblServerAddressText.Text = "Address server";
            // 
            // txtBoxServeraddress
            // 
            this.txtBoxServeraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServeraddress.Location = new System.Drawing.Point(12, 133);
            this.txtBoxServeraddress.Name = "txtBoxServeraddress";
            this.txtBoxServeraddress.Size = new System.Drawing.Size(266, 29);
            this.txtBoxServeraddress.TabIndex = 3;
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPort.Location = new System.Drawing.Point(242, 73);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(39, 29);
            this.txtBoxPort.TabIndex = 2;
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHost.Location = new System.Drawing.Point(12, 73);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(224, 29);
            this.txtBoxHost.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(549, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 16;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(526, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(15, 13);
            this.lblMin.TabIndex = 15;
            this.lblMin.Text = "--";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlTopBar.Controls.Add(this.lblMinimize);
            this.pnlTopBar.Controls.Add(this.lblMin);
            this.pnlTopBar.Controls.Add(this.lblExit);
            this.pnlTopBar.Controls.Add(this.lblClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(577, 32);
            this.pnlTopBar.TabIndex = 17;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(810, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(15, 13);
            this.lblMinimize.TabIndex = 17;
            this.lblMinimize.Text = "--";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(833, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(15, 13);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "X";
            // 
            // pnlBackgroundImage
            // 
            this.pnlBackgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlBackgroundImage.Controls.Add(this.lblTitle);
            this.pnlBackgroundImage.Controls.Add(this.pictureBox1);
            this.pnlBackgroundImage.Location = new System.Drawing.Point(0, 25);
            this.pnlBackgroundImage.Name = "pnlBackgroundImage";
            this.pnlBackgroundImage.Size = new System.Drawing.Size(577, 112);
            this.pnlBackgroundImage.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(38, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 37);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Easy index";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(577, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackgroundImage);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSavedUsers)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBackgroundImage.ResumeLayout(false);
            this.pnlBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadUserConfig;
        private System.Windows.Forms.Label lblLoginPortText;
        private System.Windows.Forms.Label lblLoginHostText;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.Label lblLoginPassText;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblServerAddressText;
        private System.Windows.Forms.TextBox txtBoxServeraddress;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.DataGridView dGridSavedUsers;
        private System.Windows.Forms.Button btnSaveUserConfig;
        private System.Windows.Forms.Button btnSshLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel pnlBackgroundImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}