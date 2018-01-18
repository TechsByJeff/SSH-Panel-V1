namespace SSH_Panel_V1
{
    partial class SshForm
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
            this.lblMin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.rTxtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblCommandText = new System.Windows.Forms.Label();
            this.btnReindexAll = new System.Windows.Forms.Button();
            this.btnReindexCatalogUrl = new System.Windows.Forms.Button();
            this.btnReindexProduct_Attribute = new System.Windows.Forms.Button();
            this.btnReindexStock = new System.Windows.Forms.Button();
            this.btnReindexProduct_price = new System.Windows.Forms.Button();
            this.btnReindexCategory_product = new System.Windows.Forms.Button();
            this.btnReindexProduct_Flat = new System.Windows.Forms.Button();
            this.btnReindexCategory_Flat = new System.Windows.Forms.Button();
            this.btnReindexCatalogSearchFullText = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pnlSelectedButton = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlIndex.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Black;
            this.lblMin.Location = new System.Drawing.Point(810, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(15, 13);
            this.lblMin.TabIndex = 19;
            this.lblMin.Text = "--";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(833, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 20;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlIndex
            // 
            this.pnlIndex.AutoScroll = true;
            this.pnlIndex.AutoSize = true;
            this.pnlIndex.BackColor = System.Drawing.Color.White;
            this.pnlIndex.Controls.Add(this.lblStatus);
            this.pnlIndex.Controls.Add(this.progressBar2);
            this.pnlIndex.Controls.Add(this.progressBar1);
            this.pnlIndex.Controls.Add(this.btnExecuteCommand);
            this.pnlIndex.Controls.Add(this.rTxtBoxOutput);
            this.pnlIndex.Controls.Add(this.txtBoxInput);
            this.pnlIndex.Controls.Add(this.lblCommandText);
            this.pnlIndex.Location = new System.Drawing.Point(270, 34);
            this.pnlIndex.Margin = new System.Windows.Forms.Padding(12);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(590, 506);
            this.pnlIndex.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 439);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(530, 23);
            this.progressBar1.TabIndex = 27;
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnExecuteCommand.FlatAppearance.BorderSize = 0;
            this.btnExecuteCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExecuteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteCommand.ForeColor = System.Drawing.Color.White;
            this.btnExecuteCommand.Location = new System.Drawing.Point(292, 408);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(263, 23);
            this.btnExecuteCommand.TabIndex = 26;
            this.btnExecuteCommand.TabStop = false;
            this.btnExecuteCommand.Text = "Uitvoeren";
            this.btnExecuteCommand.UseVisualStyleBackColor = false;
            this.btnExecuteCommand.Click += new System.EventHandler(this.btnExecuteCommand_Click);
            // 
            // rTxtBoxOutput
            // 
            this.rTxtBoxOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rTxtBoxOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTxtBoxOutput.Location = new System.Drawing.Point(25, 60);
            this.rTxtBoxOutput.Name = "rTxtBoxOutput";
            this.rTxtBoxOutput.ReadOnly = true;
            this.rTxtBoxOutput.ShortcutsEnabled = false;
            this.rTxtBoxOutput.Size = new System.Drawing.Size(530, 342);
            this.rTxtBoxOutput.TabIndex = 15;
            this.rTxtBoxOutput.TabStop = false;
            this.rTxtBoxOutput.Text = "";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInput.Location = new System.Drawing.Point(25, 29);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(530, 20);
            this.txtBoxInput.TabIndex = 9;
            // 
            // lblCommandText
            // 
            this.lblCommandText.AutoSize = true;
            this.lblCommandText.ForeColor = System.Drawing.Color.Black;
            this.lblCommandText.Location = new System.Drawing.Point(22, 13);
            this.lblCommandText.Name = "lblCommandText";
            this.lblCommandText.Size = new System.Drawing.Size(132, 13);
            this.lblCommandText.TabIndex = 8;
            this.lblCommandText.Text = "Voer hier uw commando in";
            // 
            // btnReindexAll
            // 
            this.btnReindexAll.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexAll.FlatAppearance.BorderSize = 0;
            this.btnReindexAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexAll.ForeColor = System.Drawing.Color.White;
            this.btnReindexAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReindexAll.Location = new System.Drawing.Point(12, 94);
            this.btnReindexAll.Name = "btnReindexAll";
            this.btnReindexAll.Size = new System.Drawing.Size(257, 43);
            this.btnReindexAll.TabIndex = 25;
            this.btnReindexAll.TabStop = false;
            this.btnReindexAll.Text = "reindex all";
            this.btnReindexAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReindexAll.UseVisualStyleBackColor = false;
            this.btnReindexAll.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexCatalogUrl
            // 
            this.btnReindexCatalogUrl.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexCatalogUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexCatalogUrl.FlatAppearance.BorderSize = 0;
            this.btnReindexCatalogUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogUrl.ForeColor = System.Drawing.Color.White;
            this.btnReindexCatalogUrl.Location = new System.Drawing.Point(12, 454);
            this.btnReindexCatalogUrl.Name = "btnReindexCatalogUrl";
            this.btnReindexCatalogUrl.Size = new System.Drawing.Size(257, 43);
            this.btnReindexCatalogUrl.TabIndex = 16;
            this.btnReindexCatalogUrl.TabStop = false;
            this.btnReindexCatalogUrl.Text = "catalog_url";
            this.btnReindexCatalogUrl.UseVisualStyleBackColor = false;
            this.btnReindexCatalogUrl.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexProduct_Attribute
            // 
            this.btnReindexProduct_Attribute.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexProduct_Attribute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexProduct_Attribute.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_Attribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Attribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Attribute.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_Attribute.Location = new System.Drawing.Point(11, 184);
            this.btnReindexProduct_Attribute.Name = "btnReindexProduct_Attribute";
            this.btnReindexProduct_Attribute.Size = new System.Drawing.Size(257, 43);
            this.btnReindexProduct_Attribute.TabIndex = 17;
            this.btnReindexProduct_Attribute.TabStop = false;
            this.btnReindexProduct_Attribute.Text = "product_attribute";
            this.btnReindexProduct_Attribute.UseVisualStyleBackColor = false;
            this.btnReindexProduct_Attribute.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexStock
            // 
            this.btnReindexStock.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexStock.FlatAppearance.BorderSize = 0;
            this.btnReindexStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexStock.ForeColor = System.Drawing.Color.White;
            this.btnReindexStock.Location = new System.Drawing.Point(12, 139);
            this.btnReindexStock.Name = "btnReindexStock";
            this.btnReindexStock.Size = new System.Drawing.Size(257, 43);
            this.btnReindexStock.TabIndex = 18;
            this.btnReindexStock.TabStop = false;
            this.btnReindexStock.Text = "stock";
            this.btnReindexStock.UseVisualStyleBackColor = false;
            this.btnReindexStock.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexProduct_price
            // 
            this.btnReindexProduct_price.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexProduct_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexProduct_price.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_price.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_price.Location = new System.Drawing.Point(12, 364);
            this.btnReindexProduct_price.Name = "btnReindexProduct_price";
            this.btnReindexProduct_price.Size = new System.Drawing.Size(257, 43);
            this.btnReindexProduct_price.TabIndex = 19;
            this.btnReindexProduct_price.TabStop = false;
            this.btnReindexProduct_price.Text = "product_price";
            this.btnReindexProduct_price.UseVisualStyleBackColor = false;
            this.btnReindexProduct_price.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexCategory_product
            // 
            this.btnReindexCategory_product.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexCategory_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexCategory_product.FlatAppearance.BorderSize = 0;
            this.btnReindexCategory_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_product.ForeColor = System.Drawing.Color.White;
            this.btnReindexCategory_product.Location = new System.Drawing.Point(12, 409);
            this.btnReindexCategory_product.Name = "btnReindexCategory_product";
            this.btnReindexCategory_product.Size = new System.Drawing.Size(257, 43);
            this.btnReindexCategory_product.TabIndex = 20;
            this.btnReindexCategory_product.TabStop = false;
            this.btnReindexCategory_product.Text = "category_product";
            this.btnReindexCategory_product.UseVisualStyleBackColor = false;
            this.btnReindexCategory_product.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexProduct_Flat
            // 
            this.btnReindexProduct_Flat.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexProduct_Flat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexProduct_Flat.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Flat.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_Flat.Location = new System.Drawing.Point(12, 319);
            this.btnReindexProduct_Flat.Name = "btnReindexProduct_Flat";
            this.btnReindexProduct_Flat.Size = new System.Drawing.Size(257, 43);
            this.btnReindexProduct_Flat.TabIndex = 21;
            this.btnReindexProduct_Flat.TabStop = false;
            this.btnReindexProduct_Flat.Text = "product_flat";
            this.btnReindexProduct_Flat.UseVisualStyleBackColor = false;
            this.btnReindexProduct_Flat.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexCategory_Flat
            // 
            this.btnReindexCategory_Flat.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexCategory_Flat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexCategory_Flat.FlatAppearance.BorderSize = 0;
            this.btnReindexCategory_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_Flat.ForeColor = System.Drawing.Color.White;
            this.btnReindexCategory_Flat.Location = new System.Drawing.Point(11, 229);
            this.btnReindexCategory_Flat.Name = "btnReindexCategory_Flat";
            this.btnReindexCategory_Flat.Size = new System.Drawing.Size(257, 43);
            this.btnReindexCategory_Flat.TabIndex = 22;
            this.btnReindexCategory_Flat.TabStop = false;
            this.btnReindexCategory_Flat.Text = "category_flat";
            this.btnReindexCategory_Flat.UseVisualStyleBackColor = false;
            this.btnReindexCategory_Flat.Click += new System.EventHandler(this.enterCommand);
            // 
            // btnReindexCatalogSearchFullText
            // 
            this.btnReindexCatalogSearchFullText.BackColor = System.Drawing.Color.Transparent;
            this.btnReindexCatalogSearchFullText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexCatalogSearchFullText.FlatAppearance.BorderSize = 0;
            this.btnReindexCatalogSearchFullText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogSearchFullText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogSearchFullText.ForeColor = System.Drawing.Color.White;
            this.btnReindexCatalogSearchFullText.Location = new System.Drawing.Point(12, 274);
            this.btnReindexCatalogSearchFullText.Name = "btnReindexCatalogSearchFullText";
            this.btnReindexCatalogSearchFullText.Size = new System.Drawing.Size(257, 43);
            this.btnReindexCatalogSearchFullText.TabIndex = 24;
            this.btnReindexCatalogSearchFullText.TabStop = false;
            this.btnReindexCatalogSearchFullText.Text = "fulltext";
            this.btnReindexCatalogSearchFullText.UseVisualStyleBackColor = false;
            this.btnReindexCatalogSearchFullText.Click += new System.EventHandler(this.enterCommand);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblMin);
            this.pnlTopBar.Controls.Add(this.lblClose);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(860, 35);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pnlSelectedButton);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnReindexAll);
            this.panel1.Controls.Add(this.btnReindexProduct_price);
            this.panel1.Controls.Add(this.btnReindexCatalogSearchFullText);
            this.panel1.Controls.Add(this.btnReindexCatalogUrl);
            this.panel1.Controls.Add(this.btnReindexCategory_Flat);
            this.panel1.Controls.Add(this.btnReindexProduct_Attribute);
            this.panel1.Controls.Add(this.btnReindexProduct_Flat);
            this.panel1.Controls.Add(this.btnReindexStock);
            this.panel1.Controls.Add(this.btnReindexCategory_product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 539);
            this.panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(47, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 37);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "EasyIndex";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(25, 468);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(530, 23);
            this.progressBar2.TabIndex = 27;
            // 
            // pnlSelectedButton
            // 
            this.pnlSelectedButton.BackColor = System.Drawing.Color.White;
            this.pnlSelectedButton.Location = new System.Drawing.Point(0, 94);
            this.pnlSelectedButton.Name = "pnlSelectedButton";
            this.pnlSelectedButton.Size = new System.Drawing.Size(10, 43);
            this.pnlSelectedButton.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 413);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 28;
            // 
            // SshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(860, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIndex);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SshForm";
            this.Text = "Form1";
            this.pnlIndex.ResumeLayout(false);
            this.pnlIndex.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblCommandText;
        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.Button btnReindexAll;
        private System.Windows.Forms.Button btnReindexCatalogUrl;
        private System.Windows.Forms.Button btnReindexProduct_Attribute;
        private System.Windows.Forms.Button btnReindexStock;
        private System.Windows.Forms.Button btnReindexProduct_price;
        private System.Windows.Forms.Button btnReindexCategory_product;
        private System.Windows.Forms.Button btnReindexProduct_Flat;
        private System.Windows.Forms.Button btnReindexCategory_Flat;
        private System.Windows.Forms.Button btnReindexCatalogSearchFullText;
        private System.Windows.Forms.RichTextBox rTxtBoxOutput;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel pnlSelectedButton;
        private System.Windows.Forms.Label lblStatus;
    }
}

