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
using FireSharp.Exceptions;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group9
{
    public partial class Loging : Form
    {
        public static string username;
        
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Loging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == string.Empty || txtPassword.Text == string.Empty) MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                FirebaseResponse a = client.Get("UserInformation/" + txtPhoneNumber.Text);
                SignUpInformation data = a.ResultAs<SignUpInformation>();
                SignUpInformation curuser = new SignUpInformation()
                {
                    phonenumber = txtPhoneNumber.Text,
                    password = txtPassword.Text,
                };
                if (SignUpInformation.IsEqual(data, curuser))
                {
                    MessageBox.Show("Đăng nhập thành công !!!");
                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    SignUpInformation.ShowError();
                }
            }    
        }

        private void Loging_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
