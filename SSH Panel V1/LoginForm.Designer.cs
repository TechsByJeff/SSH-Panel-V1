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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLoginUsernameText = new System.Windows.Forms.Label();
            this.lblLoginPassText = new System.Windows.Forms.Label();
            this.btnSshLogin = new System.Windows.Forms.Button();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 303);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMinimize);
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.btnSshLogin);
            this.panel2.Controls.Add(this.lblLoginUsernameText);
            this.panel2.Controls.Add(this.lblLoginText);
            this.panel2.Controls.Add(this.lblLoginPassText);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 303);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 29);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(83, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(266, 29);
            this.textBox2.TabIndex = 0;
            // 
            // lblLoginUsernameText
            // 
            this.lblLoginUsernameText.AutoSize = true;
            this.lblLoginUsernameText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsernameText.Location = new System.Drawing.Point(80, 96);
            this.lblLoginUsernameText.Name = "lblLoginUsernameText";
            this.lblLoginUsernameText.Size = new System.Drawing.Size(84, 13);
            this.lblLoginUsernameText.TabIndex = 1;
            this.lblLoginUsernameText.Text = "Gebruikersnaam";
            // 
            // lblLoginPassText
            // 
            this.lblLoginPassText.AutoSize = true;
            this.lblLoginPassText.Location = new System.Drawing.Point(80, 168);
            this.lblLoginPassText.Name = "lblLoginPassText";
            this.lblLoginPassText.Size = new System.Drawing.Size(68, 13);
            this.lblLoginPassText.TabIndex = 1;
            this.lblLoginPassText.Text = "Wachtwoord";
            // 
            // btnSshLogin
            // 
            this.btnSshLogin.BackColor = System.Drawing.Color.Green;
            this.btnSshLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSshLogin.BackgroundImage")));
            this.btnSshLogin.FlatAppearance.BorderSize = 0;
            this.btnSshLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSshLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSshLogin.ForeColor = System.Drawing.Color.White;
            this.btnSshLogin.Location = new System.Drawing.Point(218, 252);
            this.btnSshLogin.Name = "btnSshLogin";
            this.btnSshLogin.Size = new System.Drawing.Size(131, 39);
            this.btnSshLogin.TabIndex = 2;
            this.btnSshLogin.Text = "Login";
            this.btnSshLogin.UseVisualStyleBackColor = false;
            this.btnSshLogin.Click += new System.EventHandler(this.btnSshLogin_Click);
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLoginText.Location = new System.Drawing.Point(76, 40);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(101, 37);
            this.lblLoginText.TabIndex = 3;
            this.lblLoginText.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(335, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(14, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Location = new System.Drawing.Point(315, 8);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(13, 13);
            this.lblMinimize.TabIndex = 4;
            this.lblMinimize.Text = "--";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.Button btnSshLogin;
        private System.Windows.Forms.Label lblLoginPassText;
        private System.Windows.Forms.Label lblLoginUsernameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
    }
}