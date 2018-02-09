using System;
using System.Drawing;
using System.Windows.Forms;

namespace SSH_Panel_V1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        #region loginButton

        private string host;
        private string password;
        private string username;
        private int port;

        private void btnSshLogin_Click(object sender, EventArgs e)
        {
            SshForm SshForm = new SshForm();

            host = txtBoxHost.Text;
            username = txtBoxServeraddress.Text;
            password = txtBoxPassword.Text;
            port = Convert.ToInt32(txtBoxPort.Text);

            try
            {
                SSH.connect(host, username, password, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets fouts gegaan: " + ex);
            }

            if (SSH.client.IsConnected)
            {
                this.Hide();
                SshForm.Show();
            }
        }

        #endregion loginButton

        #region Config

        public void btnSaveUserConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerAddress = txtBoxServeraddress.Text;
            Properties.Settings.Default.Hostnaam = txtBoxHost.Text;
            Properties.Settings.Default.Poort = txtBoxPort.Text;
            Properties.Settings.Default.Wachtwoord = txtBoxPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btnLoadUserConfig_Click(object sender, EventArgs e)
        {
            txtBoxServeraddress.Text = Properties.Settings.Default.ServerAddress;
            txtBoxHost.Text = Properties.Settings.Default.Hostnaam;
            txtBoxPort.Text = Properties.Settings.Default.Poort;
            txtBoxPassword.Text = Properties.Settings.Default.Wachtwoord;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtBoxServeraddress.Text = Properties.Settings.Default.ServerAddress;
            txtBoxHost.Text = Properties.Settings.Default.Hostnaam;
            txtBoxPort.Text = Properties.Settings.Default.Poort;
            txtBoxPassword.Text = Properties.Settings.Default.Wachtwoord;
        }

        #endregion Config

        #region style

        private Point lastLocation;
        private bool mouseDown;

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
            this.Close();
        }

        #endregion style

    }
}