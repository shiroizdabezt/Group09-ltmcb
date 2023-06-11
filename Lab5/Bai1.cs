using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        SmtpClient smtpClient;
        NetworkCredential nc;
        private void btSend_Click(object sender, EventArgs e)
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            nc = new NetworkCredential("21522267@gm.uit.edu.vn", "ljziwmjfyilspuzo");
            smtpClient.Credentials = nc;

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("21522267@gm.uit.edu.vn");
            mm.To.Add(tbTo.Text);
            mm.Subject = tbTitle.Text;
            mm.Body = tbContent.Text;
            try
            {
                smtpClient.Send(mm);
                MessageBox.Show("Sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                mm.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
