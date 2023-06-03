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
    public partial class ConnectionForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public string dtString;
        public ConnectionForm()
        {
            InitializeComponent();
        }
        private void GetIP()
        {
            FirebaseResponse svIPre = client.Get("Server IP/");
            ServerIP dt = svIPre.ResultAs<ServerIP>();
            dtString = dt.svIP;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            GetIP();
            FirebaseResponse a = client.Get("RoomCode/");
            RoomCode data = a.ResultAs<RoomCode>();
            RoomCode currRoomCode = new RoomCode()
            {
                roomCode = textBox1.Text
            };

            if (RoomCode.IsEqual(data, currRoomCode))
            {
                InGameForm newGame = new InGameForm(false, false, dtString);
                Visible = false;
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
            else
                RoomCode.ShowError();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room room = new Room();
            room.ShowDialog();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");
        }
    }
}
