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
using System.Reflection.Metadata;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        private WebClient webClient;
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            webClient = new WebClient();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML Files|*.html";
                saveFileDialog.Title = "Bai2Lab4";
                saveFileDialog.FileName = "Bai2_Lab4.html";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    txtFilePath.Text = filePath;
                    try
                    {
                        using (Stream stream = webClient.OpenRead(url))
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string content = reader.ReadToEnd();
                                File.WriteAllText(filePath, content);
                            }
                        }

                        MessageBox.Show("Download completed.");

                        string downloadedContent = File.ReadAllText(filePath);
                        txtData.Text = downloadedContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
