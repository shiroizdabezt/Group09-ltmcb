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

        private void btnInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformationForm inforform = new InformationForm();
            inforform.ShowDialog();
            this.Close();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGameForm inGame = new InGameForm(true, false);
            inGame.ShowDialog();
            this.Close();
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
            this.Close();
        }

        void thisclose()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => this.Close()));
            }
            else
            {
                this.Close();
            }
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn đăng xuất!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res != DialogResult.OK)
            {

            }
            else
            {
                try
                {
                    thisclose();
                    MessageBox.Show("Đăng xuất thành công.");
                    Loging lg = new Loging();
                    lg.Show();
                }
                catch { }
            }
        }

        private void btnRankBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoardForm leaderBoardForm = new LeaderBoardForm();
            leaderBoardForm.ShowDialog();
            this.Close();
        }
    }
}
