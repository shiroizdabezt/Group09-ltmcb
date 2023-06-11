using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.Security.Cryptography;
using MimeKit;

namespace Lab5
{
    public partial class Bai4_XemMail : Form
    {
        private MimeMessage email;
        public Bai4_XemMail(MimeMessage email, string mk, string portSMTP)
        {
            InitializeComponent();
            this.email = email;
            LoadHtmlAsync();
            txtMK.Text = mk;
            txtSMTPPort.Text = portSMTP;
        }

        private void LoadHtmlAsync()
        {
            lbFrom.Text = email.From.ToString();
            lbTo.Text = email.To.ToString();
            lbSubject.Text = email.Subject;
            this.Text = email.Subject;

            lbFrom.Visible = true;
            lbTo.Visible = true;

            mailInfor.DocumentText = email.HtmlBody;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            string from = lbFrom.Text, to = Bai4.tk, mk = txtMK.Text, portSMTP = txtSMTPPort.Text;
            Bai4_GuiMail replyMail = new Bai4_GuiMail(to, mk, from, portSMTP);
            replyMail.ShowDialog();
        }
    }
}
