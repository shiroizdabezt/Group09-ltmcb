using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Security.Cryptography;

namespace Group9
{
    public partial class SignUpForm : Form
    {
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPhoneNumber.Text == string.Empty || txtPassword.Text == string.Empty || txtPassword2.Text == string.Empty || cmbQuestion.Text == string.Empty || txtAnswer.Text == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            else if (txtPassword.Text != txtPassword2.Text)
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp !");
            else
            {
                var signup = new SignUpInformation
                {
                    name = txtName.Text,
                    phonenumber = txtPhoneNumber.Text,
                    password = HashString(txtPassword.Text),
                    securityquestion = cmbQuestion.Text,
                    answer = txtAnswer.Text,
                    score = 400,
                    match = 0,
                    win_match = 0
                };
                SetResponse data = client.Set("UserInformation" + txtPhoneNumber.Text, signup);
                MessageBox.Show("Đăng ký thành công !!!");
                txtAnswer.Text = string.Empty;
                txtName.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPassword2.Text = string.Empty;
                cmbQuestion.Text = string.Empty;
                this.Close();
                Loging lg = new Loging();
                lg.Show();
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
            Loging lg = new Loging();
            lg.Show();
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
