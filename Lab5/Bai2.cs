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
    public partial class Bai2 : Form
    {
        ImapClient client = new ImapClient();
        public Bai2()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(txtEmail.Text, txtPass.Text);

                var inbox = client.Inbox;
                inbox.Open(MailKit.FolderAccess.ReadOnly);
                int countRecent = 0;
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    var strmess = message.From.ToString();
                    string[] row = { message.Subject, strmess, message.Date.ToString() };

                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);

                    DateTime now = message.Date.DateTime;
                    DateTime someDate = new DateTime(message.Date.Year, message.Date.Month, message.Date.Day);
                    TimeSpan timeSpan = now - someDate;
                    if (timeSpan.TotalDays <= 2) countRecent++;
                }
                txtRecent.Text = countRecent.ToString();
                txtTotal.Text = inbox.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
