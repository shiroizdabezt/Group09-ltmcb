using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(txtEmail.Text, txtPass.Text);

                int count = client.GetMessageCount();
                int countRecent = 0;

                for (int i = 0; i < count; i++)
                {
                    var message = client.GetMessage(i);
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
                txtTotal.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
