using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            port = 22;

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
                this.Hide();
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

        #region Config

        private class User
        {
            public string host { get; set; }
            public string port { get; set; }
            public string serverAddress { get; set; }
            public string password { get; set; }

            public override string ToString()
            {
                return string.Format("Host: {0} \nPoort: {1}\nServer Address: {2} \nWachtwoord: {3}", host, port, serverAddress, password);
            }
        }



        private void btnSaveUserConfig_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Hostnaam = txtBoxHost.Text;
            Properties.Settings.Default.Poort = txtBoxPort.Text;
            Properties.Settings.Default.ServerAddress = txtBoxServeraddress.Text;
            Properties.Settings.Default.Wachtwoord = txtBoxPassword.Text;
            Properties.Settings.Default.Save();


            List<User> logindata = new List<User>();
            logindata.Add(new User()
            {
                host = Properties.Settings.Default.Hostnaam,
                port = Properties.Settings.Default.Poort,
                serverAddress = Properties.Settings.Default.ServerAddress,
                password = Properties.Settings.Default.Wachtwoord
            });

         using (StreamWriter file = File.CreateText(@"C:\Users\julle\Desktop"))
         {
             JsonSerializer serializer = new JsonSerializer();
        
             serializer.Serialize(file, logindata);
         }


            
        }

        private void btnLoadUserConfig_Click(object sender, EventArgs e)
        {
            txtBoxHost.Text = Properties.Settings.Default.Hostnaam;
            txtBoxPort.Text = Properties.Settings.Default.Poort;
            txtBoxServeraddress.Text = Properties.Settings.Default.ServerAddress;
            txtBoxPassword.Text = Properties.Settings.Default.Wachtwoord;
        }

        #endregion Config
    }
}