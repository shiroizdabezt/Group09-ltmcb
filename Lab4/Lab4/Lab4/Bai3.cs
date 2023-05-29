using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        WebBrowser webBrowser;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public static string savedFilePath;
        private void initial_webBrowser()
        {
            webBrowser = new WebBrowser();
            webBrowser.Width = 749;
            webBrowser.Height = 372;
            pn_display.Controls.Add(webBrowser);
        }
        private void bt_goback_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            initial_webBrowser();
            webBrowser.Navigate(tb_url.Text);
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string url = tb_url.Text;
            using (saveFileDialog)
            {
                saveFileDialog.Filter = "HTML Files|*.html";
                saveFileDialog.Title = "Bai3Lab4";
                saveFileDialog.FileName = "Bai3_Lab4.html";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    savedFilePath = filePath;
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
                        MessageBox.Show("Your file is downloaded at " + filePath.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

        private void bt_view_resource_Click(object sender, EventArgs e)
        {
            ViewResource viewResource = new ViewResource();
            viewResource.ShowDialog();
        }
    }
}
