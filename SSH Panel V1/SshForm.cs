using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
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
            //      opgeslagen_data();
            this.Close();

            
        }

        #endregion Style

        #region buttons

        private void enterCommand(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;

            if (btnName == "btnReindexAll")
            {
                txtBoxInput.Text = "php -f questcontrol.net/shell/indexer.php reindexall";
            }
            else if (btnName == "btnReindexCatalogSearchFullText")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalogsearch_fulltext";
            }
            else if (btnName == "btnReindexCatalogUrl")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_url";
            }
            else if (btnName == "btnReindexCategory_Flat")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_flat";
            }
            else if (btnName == "btnReindexCategory_product")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_product";
            }
            else if (btnName == "btnReindexProduct_Attribute")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex cataloginventory_stock";
            }
            else if (btnName == "btnReindexProduct_Flat")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_flat";
            }
            else if (btnName == "btnReindexProduct_price")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_price";
            }
            else if (btnName == "btnReindexStock")
            {
                txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex cataloginventory_stock";
            }
        }

        private void btnExecuteCommand_Click(object sender, EventArgs e)
        {
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

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true
            };
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string input = (string)e.Argument;
            ExecuteCommand();

            ((BackgroundWorker)sender).ReportProgress(0, null);

            e.Result = null;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string myStringObject = (string)e.UserState;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string myStringResult = (string)e.Result;
        }

        #endregion Backgroundworker
    }
}