using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SSH_Panel_V1
{
    public partial class SshForm : Form
    {
        public SshForm()
        {
            InitializeComponent();
        }

        #region Style

        private Point lastLocation;
        private bool mouseDown;

        //Voegd schadow toe
        private const int CS_DROPSHADOW = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            try
            {
                SSH.disconnect();
            }
            catch { }
            Application.Exit();
        }

        #endregion Style

        #region buttons

        private string[] command = new string[] { "php -f questcontrol.net/shell/indexer.php reindexall",
        "php questcontrol.net/shell/indexer.php -- -reindex cataloginventory_stock",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_attribute",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_flat",
        "php questcontrol.net/shell/indexer.php -- -reindex catalogsearch_fulltext",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_flat",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_price",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_product",
        "php questcontrol.net/shell/indexer.php -- -reindex catalog_url",
        "php -f questcontrol.net/shell/log.php clean"
        };

        private void enterCommand(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnReindexAll":
                    txtBoxInput.Text = command[0];
                    pnlSelectedButton.Location = new Point(0, 94);
                    break;
                case "btnReindexStock":
                    txtBoxInput.Text = command[1];
                    pnlSelectedButton.Location = new Point(0, 139);
                    break;
                case "btnReindexProduct_Attribute":
                    txtBoxInput.Text = command[2];
                    pnlSelectedButton.Location = new Point(0, 184);
                    break;
                case "btnReindexCategory_Flat":
                    txtBoxInput.Text = command[3];
                    pnlSelectedButton.Location = new Point(0, 229);
                    break;
                case "btnReindexCatalogSearchFullText":
                    txtBoxInput.Text = command[4];
                    pnlSelectedButton.Location = new Point(0, 274);
                    break;
                case "btnReindexProduct_Flat":
                    txtBoxInput.Text = command[5];
                    pnlSelectedButton.Location = new Point(0, 319);
                    break;
                case "btnReindexProduct_price":
                    txtBoxInput.Text = command[6];
                    pnlSelectedButton.Location = new Point(0, 364);
                    break;
                case "btnReindexCategory_product":
                    txtBoxInput.Text = command[7];
                    pnlSelectedButton.Location = new Point(0, 409);
                    break;
                case "btnReindexCatalogUrl":
                    txtBoxInput.Text = command[8];
                    pnlSelectedButton.Location = new Point(0, 454);
                    break;
                case "btnClearLog":
                    txtBoxInput.Text = command[9];
                    pnlSelectedButton.Location = new Point(0, 526);
                    break;
            }
        }

        private void btnExecuteCommand_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Process wordt uitgevoerd...";
            lblStatus.ForeColor = Color.Orange;

            backgroundWorker.RunWorkerAsync(txtBoxInput.Text);
        }

        public void ExecuteCommand()
        {
            var cmd = SSH.client.CreateCommand(txtBoxInput.Text);
            var result = cmd.Execute();
            this.Invoke(new Action(() =>
            {
                rTxtBoxOutput.Text += result;

                var reader = new StreamReader(cmd.ExtendedOutputStream);
                rTxtBoxOutput.Text += "\n" + reader.ReadToEnd();
            }
            ));
        }

        #endregion buttons

        #region Backgroundworker

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
                ExecuteCommand();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = ("Het process is compleet");
            lblStatus.ForeColor = Color.Green;
        }

        #endregion Backgroundworker
    }
}