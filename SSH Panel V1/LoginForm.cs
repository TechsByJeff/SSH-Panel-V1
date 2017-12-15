using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        string host;
        string password;
        string username;
        int port = 22;

        private void btnSshLogin_Click(object sender, EventArgs e)
        {
            SshForm SshForm = new SshForm();

            host = txtBoxHost.Text;
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            try
            {
                SSH.connect(host, username, password, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets fouts gegaan: " + ex.ToString());
            }

            if (SSH.client.IsConnected)
            {
                SshForm.Show();
            }
            else
            {
                MessageBox.Show("er is iets fout gegaan");
            }
        }
        #endregion loginButton

        #region style

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
            this.Close();
        }

        #endregion style

    }
}
