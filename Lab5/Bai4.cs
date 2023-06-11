using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit;
using System.Net.Mail;
using MailKit.Net.Imap;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Bai4 : Form
    {
        public static string tk;
        ImapClient client = new ImapClient();
        private List<MimeMessage> emails = new List<MimeMessage>();
        private Dictionary<string, MimeMessage> emailDictionary = new Dictionary<string, MimeMessage>();
        public Bai4()
        {
            InitializeComponent();
            txtMK.PasswordChar = '*';
            txtTK.Text = "shiroizdabezt@gmail.com";
            tk = txtTK.Text;
            txtMK.Text = "eswmllpgagsraymo";
        }

        void ReadMailIMAP()
        {
            try
            {
                client.Connect("imap.gmail.com", Convert.ToInt32(numIMAPPort.Value), true);
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Authenticate(txtTK.Text, txtMK.Text);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    emails.Add(message);
                }

                // Hiển thị danh sách email trong ListView
                listView1.Items.Clear();
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);

                    ListViewItem item = new ListViewItem();

                    item.Text = message.Subject;
                    string thuTu = (i + 1).ToString();
                    string subject = message.Subject;
                    string from = message.From.ToString();
                    DateTime date = message.Date.DateTime;

                    item = new ListViewItem(new string[] { thuTu, subject, from, date.ToString() });

                    item.Tag = message.MessageId;

                    emailDictionary[message.MessageId] = message;

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                ReadMailIMAP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btn_DangNhap.Visible = false;
            btn_DangXuat.Visible = true;
            btn_send.Visible = true;
            btn_refresh.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string portSMTP = Convert.ToString(numSMTPPort.Value);
            string mk = txtMK.Text;
            if (listView1.SelectedItems.Count > 0)
            {
                int emailIndex = listView1.SelectedItems[0].Index;

                MimeMessage email = emails[emailIndex];

                Bai4_XemMail detail = new Bai4_XemMail(email: email, portSMTP, mk);

                detail.ShowDialog();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            client.Disconnect(true);
            ReadMailIMAP();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            listView1.Items.Clear();
            txtTK.Clear();
            txtMK.Clear();
            btn_DangNhap.Visible = true;
            btn_send.Visible = false;
            btn_refresh.Visible = false;
            btn_DangXuat.Visible = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string from = txtTK.Text, mk = txtMK.Text, to = "", portSMTP = Convert.ToString(numSMTPPort.Value);
            Bai4_GuiMail sendMail = new Bai4_GuiMail(from, mk, to, portSMTP);
            sendMail.Show();
        }
    }
}
