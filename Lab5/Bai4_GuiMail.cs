using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Xml.Linq;
using System.IO;

namespace Lab5
{
    public partial class Bai4_GuiMail : Form
    {
        public Bai4_GuiMail(string tk, string mk, string to, string portSMTP)
        {
            InitializeComponent();
            txtFrom.Text = tk;
            txtTo.Text = to;
            txtMK.Text = mk;
            txtSMTPPort.Text = portSMTP;
            txtFrom.Enabled = false;

            txtMK.Text = "eswmllpgagsraymo";
            txtSMTPPort.Text = 465.ToString();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtPath.Text = openFileDialog.FileName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            int port = Int32.Parse(txtSMTPPort.Text);

            smtpClient.Connect("smtp.gmail.com", port, true);
            try
            {
                string tk = txtFrom.Text, mk = txtMK.Text;
                smtpClient.Authenticate(tk, mk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(txtName.Text, txtFrom.Text));
            message.To.Add(new MailboxAddress("", txtTo.Text));
            message.Subject = txtSubject.Text;

            var bodyBuilder = new BodyBuilder();

            if (checkBox1.Checked)
            {
                bodyBuilder.HtmlBody = rtbBody.Text;

                var plainText = bodyBuilder.HtmlBody;
                bodyBuilder.TextBody = plainText;
            }
            else
            {
                bodyBuilder.TextBody = rtbBody.Text;
            }

            if (txtPath.Text != string.Empty)
            {
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(txtPath.Text)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(txtPath.Text)
                };
                bodyBuilder.Attachments.Add(attachment);
            }
            message.Body = bodyBuilder.ToMessageBody();

            smtpClient.Send(message);
        }
    }
}
