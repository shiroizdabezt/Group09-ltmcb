using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    internal class FtpClient
    {
        private string _ftpServerUrl;
        private string _ftpUsername;
        private string _ftpPassword;

        private FtpWebRequest _ftpRequest;
        private FtpWebResponse _ftpResponse;
        private Stream _stream;
        private StreamReader _reader;

        public FtpClient(string ftpServerUrl, string ftpUsername, string ftpPassword)
        {
            _ftpServerUrl = ftpServerUrl;
            _ftpUsername = ftpUsername;
            _ftpPassword = ftpPassword;
        }

        public bool Connect(string method, string path)
        {
            try
            {
                string ftpServerUrl = _ftpServerUrl;

                if (path != null)
                {
                    ftpServerUrl = string.Join("/", ftpServerUrl.TrimEnd('/'), path);
                }

                _ftpRequest = (FtpWebRequest)WebRequest.Create(ftpServerUrl);
                _ftpRequest.Credentials = new NetworkCredential(_ftpUsername, _ftpPassword);

                if (method == "listDirectory")
                    _ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                else if (method == "upload")
                    _ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                else if (method == "download")
                    _ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                if (method == "listDirectory" || method == "download")
                {
                    _ftpResponse = (FtpWebResponse)_ftpRequest.GetResponse();
                    _stream = _ftpResponse.GetResponseStream();
                    _reader = new StreamReader(_stream);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Disconnect()
        {
            if (_reader != null)
            {
                _reader.Close();
                _reader = null;
            }

            if (_stream != null)
            {
                _stream.Close();
                _stream = null;
            }

            if (_ftpResponse != null)
            {
                _ftpResponse.Close();
                _ftpResponse = null;
            }
        }

        public string[] GetFileList()
        {
            string[] fileList = null;

            try
            {
                if (Connect("listDirectory", null)) fileList = readFileList();
                fileList = readFileList();
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting file list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fileList;
        }

        public string[] GetFileList(string path)
        {
            string[] fileList = null;

            try
            {
                if (Connect("listDirectory", path)) fileList = readFileList();
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting file list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fileList;
        }

        private string[] readFileList()
        {
            List<string> fileList = new List<string>();

            string line;
            while ((line = _reader.ReadLine()) != null)
            {
                fileList.Add(line);
            }

            return fileList.ToArray();
        }

        public bool uploadFile(string localFile, string remoteFile)
        {
            try
            {
                Connect("upload", remoteFile);

                _stream = _ftpRequest.GetRequestStream();

                FileStream localFileStream = new FileStream(localFile, FileMode.Create);

                byte[] buffer = new byte[2048];
                int bytes = localFileStream.Read(buffer, 0, 2048);

                try
                {
                    while (bytes != 0)
                    {
                        _stream.Write(buffer, 0, bytes);
                        bytes = localFileStream.Read(buffer, 0, 2048);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error upload file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Disconnect();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error upload file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool downloadFile(string remoteFile, string localFile)
        {
            try
            {
                Connect("download", remoteFile);

                using (FileStream fileStream = new FileStream(localFile, FileMode.Create))
                {
                    byte[] buffer = new byte[2048];
                    int bytesRead;

                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                    Disconnect();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

