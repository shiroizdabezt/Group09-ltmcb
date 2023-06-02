using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public InformationForm()
        {
            InitializeComponent();
            lbName.Text = Loging.name;
            lbPhoneNumber.Text = Loging.phonenumber;
            lbScore.Text = Loging.score.ToString();
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
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
            FirebaseResponse a = client.Get("UserInformation/" + Loging.phonenumber);
            SignUpInformation data = a.ResultAs<SignUpInformation>();
            lbName.Text = data.name;
            lbScore.Text = data.score.ToString();
        }
    }
}
