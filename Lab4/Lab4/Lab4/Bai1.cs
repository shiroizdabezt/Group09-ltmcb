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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            response.Close();
            return responseFromServer;
        }


        private void btn_Get_Click(object sender, EventArgs e)
        {
            rtb_noidung.Text = getHTML(txt_link.Text);
        }
    }
}
