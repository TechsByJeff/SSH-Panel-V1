using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        private int port = 22;

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

        public class User
        {
            private string host;
            private string port;
            private string serveraddress;
            private string password;

            public string Host
            {
                get { return host; }
                set { host = value; }
            }
            public string Port
            {
                get { return port; }
                set { port = value; }
            }
            public string ServerAddress
            {
                get { return serveraddress; }
                set { serveraddress = value; }
            }
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
        }

        public void btnSaveUserConfig_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                User user = new User
                {
                    Host = txtBoxHost.Text,
                    Port = txtBoxPort.Text,
                    ServerAddress = txtBoxServeraddress.Text,
                    Password = txtBoxPassword.Text
                };
                XmlSave.SaveData(user,saveFileDialog.FileName);
            }

           // List<User> logindata = new List<User>();
           // logindata.Add(new User()
           // {
           //     Host = txtBoxHost.Text,
           //     Port = txtBoxPort.Text,
           //     ServerAddress = txtBoxServeraddress.Text,
           //     Password = txtBoxPassword.Text
           // });

        }

        private void btnLoadUserConfig_Click(object sender, EventArgs e)
        {
            User user = new User();
            XmlLoad<User> loadUser = new XmlLoad<User>();

            user = loadUser.LoadData("test.xml");
            txtBoxHost.Text = user.Host;
            txtBoxPort.Text = user.Port;
            txtBoxServeraddress.Text = user.ServerAddress;
            txtBoxPassword.Text = user.Password;
        }

        #endregion Config
    }
}