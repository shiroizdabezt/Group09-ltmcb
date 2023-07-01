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
/*using Universal.Common.Net.Ftp;*/
using FluentFTP;
using FluentFTP.Streams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private FtpClient _ftpClient;
        private bool isConnect = false;
        string selectedPath;
        public Form1()
        {
            InitializeComponent();
        }
        string serverIP , user, pass;
        FtpWebRequest ftpRequest;
        FtpWebResponse ftpResponse;
        private Stream ftpStream = null;
        private int bufferSize = 2048;
        private FtpClient ftpClient;
        FtpWebRequest request = null;
        FtpWebResponse response = null;
        Stream ftpstream = null;
        int lenght = 2048;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (selectedPath == null)
            {
                MessageBox.Show("Please select a folder in the tree view", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select file to upload";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string localPath = ofd.FileName;

                bool uploadSuccess = _ftpClient.uploadFile(localPath, selectedPath);

                if (uploadSuccess)
                    MessageBox.Show("File uploaded seccessfully", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Failed to upload file", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            /*if (ftpResponse != null)
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
                _ftpClient = new FtpClient(tbFtpIP.Text, tbUsername.Text, tbPass.Text);
                string[] fileList = _ftpClient.GetFileList(null);

                foreach (string fileName in fileList)
                {
                    TreeNode node = new TreeNode(fileName);
                    treeView1.Nodes.Add(node);
                }
                *//*tbFtpIP.Enabled = false;
                tbUsername.Enabled = false;
                tbPass.Enabled = false;*//*
                btnConnect.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show("Can't connect to server: " + ex.Message);
                tbFtpIP.Clear();
                tbUsername.Clear();
                tbPass.Clear();
            };*/



            if (!isConnect)
            {
                isConnect = true;
                if (string.IsNullOrEmpty(tbFtpIP.Text))
                {
                    MessageBox.Show("Error: Please enter the address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _ftpClient = new FtpClient(tbFtpIP.Text, tbUsername.Text, tbPass.Text);

                string[] fileList = _ftpClient.GetFileList(null);

                foreach (string fileName in fileList)
                {
                    TreeNode node = new TreeNode(fileName);
                    treeView1.Nodes.Add(node);
                }
                MessageBox.Show("Connected successfully!");
                btnConnect.Text = "Disconnect";
            }
            else
            {
                isConnect = false;
                treeView1.Nodes.Clear();
                btnConnect.Text = "Connect";
                MessageBox.Show("Disconnected successfully!");
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                selectedPath = e.Node.FullPath;
                selectedPath = selectedPath.Replace("\\", "/");

                string[] fileList = _ftpClient.GetFileList(selectedPath);
                if (fileList != null)
                {

                    e.Node.Nodes.Clear();

                    foreach (string file in fileList)
                    {
                        string nodeName = file;
                        int lastIndex = nodeName.LastIndexOf('/');

                        if (lastIndex != -1)
                        {
                            nodeName = nodeName.Substring(lastIndex + 1);
                        }

                        TreeNode node = new TreeNode(nodeName);
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (selectedPath == null)
            {
                MessageBox.Show("Please select a file to downloadw", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Save file";

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string saveFolderPath = folderBrowserDialog.SelectedPath;
                string fileName = selectedPath.Substring(selectedPath.LastIndexOf('/') + 1);
                string saveFilePath = Path.Combine(saveFolderPath, fileName);

                bool downloadSuccess = _ftpClient.downloadFile(selectedPath, saveFilePath);

                if (downloadSuccess)
                    MessageBox.Show("File downloaded successfully", "Download Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to download file", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
