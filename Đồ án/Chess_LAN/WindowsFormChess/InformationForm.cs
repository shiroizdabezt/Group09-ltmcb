using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            lbName.Text = Loging.name;
            lbPhoneNumber.Text = Loging.phonenumber;
            lbScore.Text = Loging.score.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }

        private void btn_Changename1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserNameForm change = new ChangeUserNameForm();
            change.ShowDialog();
            this.Close();
        }

        private void btn_ChangePass1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassForm change = new ChangePassForm();
            change.ShowDialog();
            this.Close();
        }

        private void btn_Refresh1_Click(object sender, EventArgs e)
        {

        }
    }
}
