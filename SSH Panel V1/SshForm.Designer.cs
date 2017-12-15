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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SshForm));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlBackgroundImage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblCommandText = new System.Windows.Forms.Label();
            this.rTxtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.btnReindexCatalogUrl = new System.Windows.Forms.Button();
            this.btnReindexProduct_Attribute = new System.Windows.Forms.Button();
            this.btnReindexStock = new System.Windows.Forms.Button();
            this.btnReindexProduct_price = new System.Windows.Forms.Button();
            this.btnReindexCategory_product = new System.Windows.Forms.Button();
            this.btnReindexProduct_Flat = new System.Windows.Forms.Button();
            this.btnReindexCategory_Flat = new System.Windows.Forms.Button();
            this.btnReindexProduct_url = new System.Windows.Forms.Button();
            this.btnReindexCatalogSearchFullText = new System.Windows.Forms.Button();
            this.btnCmd1 = new System.Windows.Forms.Button();
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            this.pnlBackgroundImage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlTopBar.Controls.Add(this.lblMin);
            this.pnlTopBar.Controls.Add(this.lblClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(860, 35);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // pnlBackgroundImage
            // 
            this.pnlBackgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlBackgroundImage.Controls.Add(this.pictureBox1);
            this.pnlBackgroundImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBackgroundImage.Location = new System.Drawing.Point(0, 35);
            this.pnlBackgroundImage.Name = "pnlBackgroundImage";
            this.pnlBackgroundImage.Size = new System.Drawing.Size(860, 174);
            this.pnlBackgroundImage.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExecuteCommand);
            this.panel2.Controls.Add(this.btnCmd1);
            this.panel2.Controls.Add(this.btnReindexCatalogUrl);
            this.panel2.Controls.Add(this.btnReindexProduct_Attribute);
            this.panel2.Controls.Add(this.btnReindexStock);
            this.panel2.Controls.Add(this.btnReindexProduct_price);
            this.panel2.Controls.Add(this.btnReindexCategory_product);
            this.panel2.Controls.Add(this.btnReindexProduct_Flat);
            this.panel2.Controls.Add(this.btnReindexCategory_Flat);
            this.panel2.Controls.Add(this.btnReindexProduct_url);
            this.panel2.Controls.Add(this.btnReindexCatalogSearchFullText);
            this.panel2.Controls.Add(this.rTxtBoxOutput);
            this.panel2.Controls.Add(this.txtBoxInput);
            this.panel2.Controls.Add(this.lblCommandText);
            this.panel2.Location = new System.Drawing.Point(36, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 407);
            this.panel2.TabIndex = 3;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(153, 16);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(519, 20);
            this.txtBoxInput.TabIndex = 9;
            // 
            // lblCommandText
            // 
            this.lblCommandText.AutoSize = true;
            this.lblCommandText.ForeColor = System.Drawing.Color.Black;
            this.lblCommandText.Location = new System.Drawing.Point(15, 19);
            this.lblCommandText.Name = "lblCommandText";
            this.lblCommandText.Size = new System.Drawing.Size(132, 13);
            this.lblCommandText.TabIndex = 8;
            this.lblCommandText.Text = "Voer hier uw commando in";
            // 
            // rTxtBoxOutput
            // 
            this.rTxtBoxOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTxtBoxOutput.Location = new System.Drawing.Point(153, 42);
            this.rTxtBoxOutput.Name = "rTxtBoxOutput";
            this.rTxtBoxOutput.ReadOnly = true;
            this.rTxtBoxOutput.ShortcutsEnabled = false;
            this.rTxtBoxOutput.Size = new System.Drawing.Size(610, 284);
            this.rTxtBoxOutput.TabIndex = 15;
            this.rTxtBoxOutput.TabStop = false;
            this.rTxtBoxOutput.Text = "";
            // 
            // btnReindexCatalogUrl
            // 
            this.btnReindexCatalogUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexCatalogUrl.FlatAppearance.BorderSize = 0;
            this.btnReindexCatalogUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogUrl.ForeColor = System.Drawing.Color.White;
            this.btnReindexCatalogUrl.Location = new System.Drawing.Point(18, 274);
            this.btnReindexCatalogUrl.Name = "btnReindexCatalogUrl";
            this.btnReindexCatalogUrl.Size = new System.Drawing.Size(129, 23);
            this.btnReindexCatalogUrl.TabIndex = 16;
            this.btnReindexCatalogUrl.TabStop = false;
            this.btnReindexCatalogUrl.Text = "catalog_url";
            this.btnReindexCatalogUrl.UseVisualStyleBackColor = false;
            // 
            // btnReindexProduct_Attribute
            // 
            this.btnReindexProduct_Attribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexProduct_Attribute.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_Attribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Attribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Attribute.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_Attribute.Location = new System.Drawing.Point(18, 71);
            this.btnReindexProduct_Attribute.Name = "btnReindexProduct_Attribute";
            this.btnReindexProduct_Attribute.Size = new System.Drawing.Size(129, 23);
            this.btnReindexProduct_Attribute.TabIndex = 17;
            this.btnReindexProduct_Attribute.TabStop = false;
            this.btnReindexProduct_Attribute.Text = "product_attribute";
            this.btnReindexProduct_Attribute.UseVisualStyleBackColor = false;
            // 
            // btnReindexStock
            // 
            this.btnReindexStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexStock.FlatAppearance.BorderSize = 0;
            this.btnReindexStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexStock.ForeColor = System.Drawing.Color.White;
            this.btnReindexStock.Location = new System.Drawing.Point(18, 303);
            this.btnReindexStock.Name = "btnReindexStock";
            this.btnReindexStock.Size = new System.Drawing.Size(129, 23);
            this.btnReindexStock.TabIndex = 18;
            this.btnReindexStock.TabStop = false;
            this.btnReindexStock.Text = "stock";
            this.btnReindexStock.UseVisualStyleBackColor = false;
            // 
            // btnReindexProduct_price
            // 
            this.btnReindexProduct_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexProduct_price.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_price.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_price.Location = new System.Drawing.Point(18, 100);
            this.btnReindexProduct_price.Name = "btnReindexProduct_price";
            this.btnReindexProduct_price.Size = new System.Drawing.Size(129, 23);
            this.btnReindexProduct_price.TabIndex = 19;
            this.btnReindexProduct_price.TabStop = false;
            this.btnReindexProduct_price.Text = "product_price";
            this.btnReindexProduct_price.UseVisualStyleBackColor = false;
            // 
            // btnReindexCategory_product
            // 
            this.btnReindexCategory_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexCategory_product.FlatAppearance.BorderSize = 0;
            this.btnReindexCategory_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_product.ForeColor = System.Drawing.Color.White;
            this.btnReindexCategory_product.Location = new System.Drawing.Point(18, 216);
            this.btnReindexCategory_product.Name = "btnReindexCategory_product";
            this.btnReindexCategory_product.Size = new System.Drawing.Size(129, 23);
            this.btnReindexCategory_product.TabIndex = 20;
            this.btnReindexCategory_product.TabStop = false;
            this.btnReindexCategory_product.Text = "category_product";
            this.btnReindexCategory_product.UseVisualStyleBackColor = false;
            // 
            // btnReindexProduct_Flat
            // 
            this.btnReindexProduct_Flat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexProduct_Flat.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Flat.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_Flat.Location = new System.Drawing.Point(18, 158);
            this.btnReindexProduct_Flat.Name = "btnReindexProduct_Flat";
            this.btnReindexProduct_Flat.Size = new System.Drawing.Size(129, 23);
            this.btnReindexProduct_Flat.TabIndex = 21;
            this.btnReindexProduct_Flat.TabStop = false;
            this.btnReindexProduct_Flat.Text = "product_flat";
            this.btnReindexProduct_Flat.UseVisualStyleBackColor = false;
            // 
            // btnReindexCategory_Flat
            // 
            this.btnReindexCategory_Flat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexCategory_Flat.FlatAppearance.BorderSize = 0;
            this.btnReindexCategory_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_Flat.ForeColor = System.Drawing.Color.White;
            this.btnReindexCategory_Flat.Location = new System.Drawing.Point(18, 187);
            this.btnReindexCategory_Flat.Name = "btnReindexCategory_Flat";
            this.btnReindexCategory_Flat.Size = new System.Drawing.Size(129, 23);
            this.btnReindexCategory_Flat.TabIndex = 22;
            this.btnReindexCategory_Flat.TabStop = false;
            this.btnReindexCategory_Flat.Text = "category_flat";
            this.btnReindexCategory_Flat.UseVisualStyleBackColor = false;
            // 
            // btnReindexProduct_url
            // 
            this.btnReindexProduct_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexProduct_url.FlatAppearance.BorderSize = 0;
            this.btnReindexProduct_url.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_url.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_url.ForeColor = System.Drawing.Color.White;
            this.btnReindexProduct_url.Location = new System.Drawing.Point(18, 129);
            this.btnReindexProduct_url.Name = "btnReindexProduct_url";
            this.btnReindexProduct_url.Size = new System.Drawing.Size(129, 23);
            this.btnReindexProduct_url.TabIndex = 23;
            this.btnReindexProduct_url.TabStop = false;
            this.btnReindexProduct_url.Text = "product_url";
            this.btnReindexProduct_url.UseVisualStyleBackColor = false;
            // 
            // btnReindexCatalogSearchFullText
            // 
            this.btnReindexCatalogSearchFullText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnReindexCatalogSearchFullText.FlatAppearance.BorderSize = 0;
            this.btnReindexCatalogSearchFullText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogSearchFullText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogSearchFullText.ForeColor = System.Drawing.Color.White;
            this.btnReindexCatalogSearchFullText.Location = new System.Drawing.Point(18, 245);
            this.btnReindexCatalogSearchFullText.Name = "btnReindexCatalogSearchFullText";
            this.btnReindexCatalogSearchFullText.Size = new System.Drawing.Size(129, 23);
            this.btnReindexCatalogSearchFullText.TabIndex = 24;
            this.btnReindexCatalogSearchFullText.TabStop = false;
            this.btnReindexCatalogSearchFullText.Text = "fulltext";
            this.btnReindexCatalogSearchFullText.UseVisualStyleBackColor = false;
            // 
            // btnCmd1
            // 
            this.btnCmd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnCmd1.FlatAppearance.BorderSize = 0;
            this.btnCmd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmd1.ForeColor = System.Drawing.Color.White;
            this.btnCmd1.Location = new System.Drawing.Point(18, 42);
            this.btnCmd1.Name = "btnCmd1";
            this.btnCmd1.Size = new System.Drawing.Size(129, 23);
            this.btnCmd1.TabIndex = 25;
            this.btnCmd1.TabStop = false;
            this.btnCmd1.Text = "reindex all";
            this.btnCmd1.UseVisualStyleBackColor = false;
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnExecuteCommand.FlatAppearance.BorderSize = 0;
            this.btnExecuteCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExecuteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteCommand.ForeColor = System.Drawing.Color.White;
            this.btnExecuteCommand.Location = new System.Drawing.Point(678, 14);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(85, 23);
            this.btnExecuteCommand.TabIndex = 26;
            this.btnExecuteCommand.TabStop = false;
            this.btnExecuteCommand.Text = "Uitvoeren";
            this.btnExecuteCommand.UseVisualStyleBackColor = false;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
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
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(833, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 20;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBackgroundImage);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SshForm";
            this.Text = "Form1";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBackgroundImage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBackgroundImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblCommandText;
        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.Button btnCmd1;
        private System.Windows.Forms.Button btnReindexCatalogUrl;
        private System.Windows.Forms.Button btnReindexProduct_Attribute;
        private System.Windows.Forms.Button btnReindexStock;
        private System.Windows.Forms.Button btnReindexProduct_price;
        private System.Windows.Forms.Button btnReindexCategory_product;
        private System.Windows.Forms.Button btnReindexProduct_Flat;
        private System.Windows.Forms.Button btnReindexCategory_Flat;
        private System.Windows.Forms.Button btnReindexProduct_url;
        private System.Windows.Forms.Button btnReindexCatalogSearchFullText;
        private System.Windows.Forms.RichTextBox rTxtBoxOutput;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

