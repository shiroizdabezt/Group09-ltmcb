using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0LD4V9MeOsWxjFEQnVuVuzC6OwAHp1iy4aPrOaiR",
            BasePath = "https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public static string Roomcode;
        public static int port;
        private static Random random = new Random();
        const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string localIP;
        public static string GenerateRoomCode()
        {
            char[] chars = new char[6];
            for (int i = 0; i < 6; i++)
            {
                chars[i] = allowedChars[random.Next(allowedChars.Length)];
            }
            return new string(chars);
        }
        private static int GeneratePort()
        {
            Random rand = new Random();
            return rand.Next(1024, 49152);
        }
        private void TakeServerIP()
        {
            IPAddress[] localIPs = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = addr.ToString();
                    break;
                }
            }
            var sIP = new ServerIP
            {
                svIP = localIP
            };
            SetResponse sr = client.Set("Server IP/", sIP);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) ;
            else MessageBox.Show("Kết nối Firebase không thành công !!!");

            Roomcode = GenerateRoomCode();
            lb_room_code.Text = Roomcode;
            var rc = new RoomCode
            {
                roomCode = Roomcode
            };
            SetResponse sr = client.Set("RoomCode/", rc);
            TakeServerIP();
            port = GeneratePort();
            var P = new Port
            {
                p = port
            };
            SetResponse sp = client.Set("Port/", P);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InGameForm newGame = new InGameForm(false, true, null, port);
            Visible = false;
            if (!newGame.IsDisposed) newGame.ShowDialog();
            Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ConnectionForm form = new ConnectionForm();
            form.ShowDialog();
        }
    }
}
