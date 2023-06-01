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
    public partial class ChangePassForm : Form
    {
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
            FirebaseResponse a = client.Get("UserInformation/" + txtPhoneNumber.Text);
            SignUpInformation data = a.ResultAs<SignUpInformation>();
            SignUpInformation curuser = new SignUpInformation()
            {
                password = txtPassword.Text,
                phonenumber = txtPhoneNumber.Text,
            };
            if (data == null) 
                MessageBox.Show("Tài khoản không tồn tại");
            else
            {
                if (data.phonenumber == curuser.phonenumber && data.password == curuser.password)
                {
                    data.password = txtNewPassword.Text;
                    SetResponse newdata = client.Set("UserInformation/" + txtPhoneNumber.Text, data);
                    MessageBox.Show("Thay đổi mật khẩu mới thành công.");
                }
                else
                {
                    if (data.password != curuser.password)
                        MessageBox.Show("Mật khẩu cũ không trùng khớp.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            InformationForm inforform = new InformationForm();
            inforform.Show();
        }

        private void ChangePassForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
