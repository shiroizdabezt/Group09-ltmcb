﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9
{
    public class SignUpInformation
    {
        public string? name
        {
            get; set;
        } = null;
        public string? phonenumber
        {
            get; set;
        } = null;
        public string? password
        {
            get; set;
        } = null;
        public string? securityquestion
        {
            get; set;
        } = null;
        public string? answer
        {
            get; set;
        } = null;
        public int score
        { 
            get; set; 
        }
        private static string error = "Tài khoản này không tồn tại.";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(SignUpInformation user1, SignUpInformation user2)
        {
            if (user1 == null || user2 == null) return false;
            if (user1.password != user2.password)
            {
                error = "Mật khẩu sai. Vui lòng thử lại.";
                return false;
            }
            return true;
        }
    }
}
