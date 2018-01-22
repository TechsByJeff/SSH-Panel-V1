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
        private int port = 22 ;

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

            [JsonProperty("Host")]
            public string Host { get; set; }

            [JsonProperty("Port")]
            public string Port { get; set; }

            [JsonProperty("ServerAddress")]
            public string ServerAddress { get; set; }

            [JsonProperty("Password")]
            public string Password { get; set; }

            public static List<User> logindata = new List<User>();
        }

        void GetData()
        {

            using (StreamReader r = new StreamReader("data.json")) // variabel voor locatie bestand nog maken
            {
                dGridSavedUsers.DataSource = User.logindata;
            }
            
        }

        public void btnSaveUserConfig_Click(object sender, EventArgs e)
        {

            List<User> logindata = new List<User>();
            logindata.Add(new User()
            {
                Host = txtBoxHost.Text,
                Port = txtBoxPort.Text,
                ServerAddress = txtBoxServeraddress.Text,
                Password = txtBoxPassword.Text
            });

            //Serialize JSON naar een string en schrijf dan de string naar een bestand
            //     File.WriteAllText(@"C:\Users\julle\Source\Repos\SSH-Panel-V1\SSH Panel V1\bin\Debug\data.txt", JsonConvert.SerializeObject(logindata));

            // Serialize JSON direct naar een bestand
            using (StreamWriter file = File.AppendText(@"C:\Users\julle\Source\Repos\SSH-Panel-V1\SSH Panel V1\bin\Debug\data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, logindata);
            }
        }

        private void btnLoadUserConfig_Click(object sender, EventArgs e)
        {
            GetData();
           
        }

        #endregion Config
    }
}