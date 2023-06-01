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
    public partial class ChangeUserNameForm : Form
    {
        public static string name;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public ChangeUserNameForm()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            /*FirebaseResponse newdata = client.Get("UserInformation/" + Loging.name);

            SignUpInformation data = newdata.ResultAs<SignUpInformation>();

            SignUpInformation curuser = new SignUpInformation()
            {
                name = txt_NewUsername.Text,
            };
            data.name = curuser.name;
            SetResponse newdata2 = client.Set("UserInformation/" + Loging.name, data);
            MessageBox.Show("Thay đổi tên thành công.");*/
        }
    }
}
