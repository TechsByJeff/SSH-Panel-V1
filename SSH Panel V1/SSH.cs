using Renci.SshNet;
using System;
using System.Windows.Forms;

namespace SSH_Panel_V1
{
    public class SSH
    {
        #region SSH Variabels

        public static SshClient client;

        #endregion SSH Variabels

        #region SSH Connection

        // Connect naar de SSH client
        public static string connect(string hostname, string username, string password, int port = 22)
        {
            try //Error handeling voor de SSH client
            {
                client = new SshClient(hostname, port, username, password); //Create the SSH object
                client.Connect(); //Connect the SSH object
                return null; //Return no errors
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrent wrong while disconnecting to your SSH server:" + Environment.NewLine + ex.ToString()); //Return error);
                return null;
            }
        }

        // Disconnect van de SSH client
        public static string disconnect()
        {
            try //Error handeling for this SSH client
            {
                client.Disconnect(); //Dissconnects the client
                client.Dispose(); //Remove all settings in the client
                return null; //Return no errors
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrent wrong while disconnecting to your SSH server:" + Environment.NewLine + ex.ToString()); //Return error);
                return null;
            }
        }

        #endregion SSH Connection

        #region SSH Commands

        // Voert commando uit op de SSH
        public static string executeCmd(string command)
        {
            try //Error handeling voor de SSH client
            {
                SshCommand cmd = client.CreateCommand(command); //Create command object
                return cmd.Execute(); //Return the command result
            }
            catch (Exception ex)
            {
                return "Error while executing this command: " + Environment.NewLine + ex.ToString(); // Return error
            }
        }

        #endregion SSH Commands
    }
}