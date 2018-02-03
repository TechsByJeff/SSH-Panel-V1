using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
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
            string btnName = ((Button)sender).Name;

            if (btnName == "btnReindexAll")
            {
                txtBoxInput.Text = command[0];
                pnlSelectedButton.Location = new Point(0, 94);
            }
            else if (btnName == "btnReindexStock")
            {
                txtBoxInput.Text = command[1];
                pnlSelectedButton.Location = new Point(0, 139);
            }
            else if (btnName == "btnReindexProduct_Attribute")
            {
                txtBoxInput.Text = command[2];
                pnlSelectedButton.Location = new Point(0, 184);
            }
            else if (btnName == "btnReindexCategory_Flat")
            {
                txtBoxInput.Text = command[3];
                pnlSelectedButton.Location = new Point(0, 229);
            }
            else if (btnName == "btnReindexCatalogSearchFullText")
            {
                txtBoxInput.Text = command[4];
                pnlSelectedButton.Location = new Point(0, 274);
            }
            else if (btnName == "btnReindexProduct_Flat")
            {
                txtBoxInput.Text = command[5];
                pnlSelectedButton.Location = new Point(0, 319);
            }
            else if (btnName == "btnReindexProduct_price")
            {
                txtBoxInput.Text = command[6];
                pnlSelectedButton.Location = new Point(0, 364);
            }
            else if (btnName == "btnReindexCategory_product")
            {
                txtBoxInput.Text = command[7];
                pnlSelectedButton.Location = new Point(0, 409);
            }
            else if (btnName == "btnReindexCatalogUrl")
            {
                txtBoxInput.Text = command[8];
                pnlSelectedButton.Location = new Point(0, 454);
            }
            else if (btnName == "btnClearLog")
            {
                txtBoxInput.Text = command[9];
                pnlSelectedButton.Location = new Point(0, 526);
            }
        }

        private void btnExecuteCommand_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Process wordt uitgevoerd...";
            lblStatus.ForeColor = Color.Orange;

            backgroundWorker.RunWorkerAsync(txtBoxInput.Text);
            InitializeBackgroundWorker();
        }

        #region Reindex_Tasks

        public async Task ReindexStock()
        {
            await Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    btnReindexStock.PerformClick();
                    txtBoxInput.Text = command[1];
                    ExecuteCommand();
                }));
            });
        }

        public async Task Product_Attribute()
        {
            this.Invoke(new Action(() =>
            {
                btnReindexProduct_Attribute.PerformClick();
                txtBoxInput.Text = command[2];
                ExecuteCommand();
            }
          ));
        }

        public async Task Category_Flat()
        {

        }

        public async Task FullText()
        {

        }

        public async Task Product_Flat()
        {

        }

        public async Task Product_Price()
        {

        }

        public async Task Category_Product()
        {

        }
        public async Task Catalog_Url()
        {
            
        }
        #endregion tasks
        private void ReindexAll()
        {
            #region Reindex_Task

            //    Task ReindexStock = new Task(delegate
            //    {
            //        this.Invoke(new Action(() =>
            //        {
            //            btnReindexStock.PerformClick();
            //            txtBoxInput.Text = command[1];
            //            ExecuteCommand();
            //        }
            //        ));
            //    });
            //    ReindexStock.Start();
            //    ReindexStock.Wait();

            //       Task Product_attribute = new Task(delegate
            //       {
            //         this.Invoke(new Action(() =>
            //         {
            //             btnReindexProduct_Attribute.PerformClick();
            //    txtBoxInput.Text = command[2];
            //    ExecuteCommand();
            //      }
            //      ));
            //         

            //       });
            //       Product_attribute.Start();
            //       Product_attribute.Wait();
            //       Task Category_Flat = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexCategory_Flat.PerformClick();
            //               txtBoxInput.Text = command[3];
            //               ExecuteCommand();
            //           }
            //           ));
            //       });
            //       Category_Flat.Start();
            //       Category_Flat.Wait();
            //    
            //       Task FullText = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexCatalogSearchFullText.PerformClick();
            //               txtBoxInput.Text = command[5];
            //               ExecuteCommand();
            //           }
            //           ));
            //       });
            //       FullText.Start();
            //       FullText.Wait();
            //       Task Product_Flat = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexProduct_Flat.PerformClick();
            //               txtBoxInput.Text = command[5];
            //               ExecuteCommand();
            //           }
            //           ));
            //       });
            //       Product_Flat.Start();
            //       Product_Flat.Wait();
            //       Task Product_Price = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexProduct_Flat.PerformClick();
            //               txtBoxInput.Text = command[6];
            //               ExecuteCommand();
            //           }
            //           ));
            //       });
            //       Product_Price.Start();
            //       Product_Price.Wait();
            //       Task Category_Product = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexCategory_product.PerformClick();
            //               txtBoxInput.Text = command[7];
            //               ExecuteCommand();
            //           }
            //          ));
            //       });
            //       Category_Product.Start();
            //       Category_Product.Wait();
            //       Task Catalog_Url = new Task(() =>
            //       {
            //           this.Invoke(new Action(() =>
            //           {
            //               btnReindexCatalogUrl.PerformClick();
            //               txtBoxInput.Text = command[8];
            //               ExecuteCommand();
            //           }
            //           ));
            //       });
            //       Catalog_Url.Start();
            //       Catalog_Url.Wait();

            #endregion Task

            #region thread

            //   new Thread(() =>
            //           {
            //               MessageBox.Show("yolo1");
            //               btnReindexStock.PerformClick();
            //               txtBoxInput.Text = command[1];
            //               ExecuteCommand();
            //           }).Start();
            //
            //   new Thread(() =>
            //   {
            //       MessageBox.Show("yolo1");
            //       btnReindexProduct_Attribute.PerformClick();
            //       txtBoxInput.Text = command[2];
            //       ExecuteCommand();
            //   }).Start();


            //   new Thread(() => {
            //
            //       this.Invoke(new Action(() =>
            //       {
            //           btnReindexStock.PerformClick();
            //           txtBoxInput.Text = command[1];
            //           ExecuteCommand();
            //       }));
            //   })
            //   { IsBackground = true }.Start();
            //
            //   new Thread(() => {
            //
            //       this.Invoke(new Action(() =>
            //       {
            //           btnReindexProduct_Attribute.PerformClick();
            //           txtBoxInput.Text = command[2];
            //           ExecuteCommand();
            //       }));
            //       
            //   })
            //   { IsBackground = true }.Start();
            #endregion thread

            #region Threadpool.QeueUserWorkItem

            //   ThreadPool.QueueUserWorkItem(delegate
            //   {
            //       MessageBox.Show("yolo");
            //       btnReindexStock.PerformClick();
            //       txtBoxInput.Text = command[1];
            //       ExecuteCommand();
            //   });
            //   ThreadPool.QueueUserWorkItem(delegate
            //   {
            //       MessageBox.Show("yolo1");
            //       btnReindexProduct_Attribute.PerformClick();
            //       txtBoxInput.Text = command[2];
            //       ExecuteCommand();
            //   });

            #endregion Threadpool.QeueUserWorkItem
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
        //    backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (txtBoxInput.Text == command[0])
            {
                // new Thread(new ThreadStart(ReindexAll)).Start();

                //Thread t = new Thread(new ThreadStart(ReindexAll));
                //t.Start();
                //t.IsBackground = true;

                //  Task.Factory.StartNew(() => ReindexAll());

                ReindexStock();
                Product_Attribute();
            }
            else
            {
                ExecuteCommand();
            }
        }

    //   private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    //   {
    //   }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = ("Het process is compleet");
            lblStatus.ForeColor = Color.Green;
        }

        #endregion Backgroundworker
    }
}