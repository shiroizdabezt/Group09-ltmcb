using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string serverIP , user, pass;
        FtpWebRequest ftpRequest;
        FtpWebResponse ftpResponse;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            tbFtpIP.Text = "ftp://" + tbFtpIP.Text;
            serverIP = tbFtpIP.Text;
            user = tbUsername.Text;
            pass = tbPass.Text;
            if (ftpResponse != null)
            {
                ftpResponse.Close();
            }
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(serverIP);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                btnConnect.Enabled=true;
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Can't connect to server: " + ex.Message); };
        }
    }
}
