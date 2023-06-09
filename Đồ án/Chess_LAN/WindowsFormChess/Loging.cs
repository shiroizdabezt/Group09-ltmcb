﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using System.Security.Cryptography;

namespace Group9
{
    public partial class Loging : Form
    {
        public static string name;
        public static string phonenumber;
        public static int score;
        public static int match;
        public static int winMatch;

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
             
        }

        private void Loging_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
        }

        private void btnForgot1_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotpass = new ForgotPasswordForm();
            forgotpass.Show();
            this.Hide();
        }

        private void btnSignUp1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void Loging_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Q = MessageBox.Show("Bạn có chắc muốn thoát Game?", "Warning!", MessageBoxButtons.OKCancel);
            if (Q == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else System.Windows.Forms.Application.ExitThread();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == string.Empty || txtPassword.Text == string.Empty) MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                FirebaseResponse a = client.Get("UserInformation" + txtPhoneNumber.Text);
                SignUpInformation data = a.ResultAs<SignUpInformation>();
                SignUpInformation curuser = new SignUpInformation()
                {
                    phonenumber = txtPhoneNumber.Text,
                    password = HashString(txtPassword.Text),
                };
                if (SignUpInformation.IsEqual(data, curuser))
                {
                    Loging.name = data.name;
                    Loging.phonenumber = data.phonenumber;
                    Loging.score = data.score;
                    Loging.match = data.match;
                    Loging.winMatch = data.win_match;
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
