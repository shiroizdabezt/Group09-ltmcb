using Microsoft.Win32;
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
        private static string error = "Chưa tạo tk này mà đòi chơi cái con đĩ bò mày";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(SignUpInformation user1, SignUpInformation user2)
        {
            if (user1 == null || user2 == null) return false;
            if (user1.password != user2.password)
            {
                error = "Sai mk rồi con đĩ bò";
                return false;
            }
            return true;
        }
    }
}
