using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
            FirebaseResponse a = client.Get("UserInformation" + txtPhoneNumber.Text);
            SignUpInformation data = a.ResultAs<SignUpInformation>();
            SignUpInformation curuser = new SignUpInformation()
            {
                password = HashString(txtPassword.Text),
                phonenumber = txtPhoneNumber.Text,
            };
            if (txtPhoneNumber.Text == string.Empty || txtPassword.Text == string.Empty || txtPass1.Text == string.Empty || txtNewPassword.Text == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            else
            {
                if (data == null)
                    MessageBox.Show("Tài khoản không tồn tại");
                else if (txtNewPassword.Text != txtPass1.Text)
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                else
                {
                    if (data.phonenumber == curuser.phonenumber && data.password == curuser.password)
                    {
                        data.password = HashString(txtNewPassword.Text);
                        SetResponse newdata = client.Set("UserInformation" + txtPhoneNumber.Text, data);
                        MessageBox.Show("Thay đổi mật khẩu mới thành công.");
                    }
                    else
                    {
                        if (data.password != curuser.password)
                            MessageBox.Show("Mật khẩu cũ không trùng khớp.");
                    }
                }
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
            InformationForm inforform = new InformationForm();
            inforform.Show();
        }

        public string HashString(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
