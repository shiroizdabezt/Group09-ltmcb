using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGameForm inGame = new InGameForm(true, false);
            inGame.ShowDialog();
            this.Close();
        }

        private void Connection_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
            this.Close();

        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformationForm inforform = new InformationForm();
            inforform.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn đăng xuất!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res != DialogResult.OK)
            {
                //e. = true;
            }
            else
            {
                try
                {
                    this.Close();
                    MessageBox.Show("Đăng xuất thành công.");
                    Loging lg = new Loging();
                    lg.ShowDialog();
                }
                catch { }
            }
        }
    }
}
