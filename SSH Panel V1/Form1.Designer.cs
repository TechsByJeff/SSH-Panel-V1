namespace SSH_Panel_V1
{
    partial class Form1
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlCredits = new System.Windows.Forms.Panel();
            this.pnlIcons = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.DimGray;
            this.pnlButtons.Controls.Add(this.pnlIcons);
            this.pnlButtons.Controls.Add(this.pnlCredits);
            this.pnlButtons.Controls.Add(this.pnlLogo);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(233, 539);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 109);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlCredits
            // 
            this.pnlCredits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCredits.Location = new System.Drawing.Point(0, 512);
            this.pnlCredits.Name = "pnlCredits";
            this.pnlCredits.Size = new System.Drawing.Size(233, 27);
            this.pnlCredits.TabIndex = 1;
            // 
            // pnlIcons
            // 
            this.pnlIcons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIcons.Location = new System.Drawing.Point(0, 109);
            this.pnlIcons.Name = "pnlIcons";
            this.pnlIcons.Size = new System.Drawing.Size(46, 403);
            this.pnlIcons.TabIndex = 2;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(233, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(627, 85);
            this.pnlTopBar.TabIndex = 1;
            // 
            // pnlControls
            // 
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(233, 429);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(627, 110);
            this.pnlControls.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(233, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(627, 344);
            this.pnlMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 539);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlIcons;
        private System.Windows.Forms.Panel pnlCredits;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlMain;
    }
}

