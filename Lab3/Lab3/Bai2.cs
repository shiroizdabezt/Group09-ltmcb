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

namespace Lab3
{
    public partial class bai2 : Form
    {
        IPEndPoint IP;
        Socket server;
        IPAddress ip;
        public bai2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void bt_listen_Click(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Connect();
            MessageBox.Show("Listening at 127.0.0.1:8080", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_listen.Enabled = false;
        }
        void Receive(object obj)
        {
            int bytesReceived = 0;
            Socket client = obj as Socket;
            while (true)
            {
                if (!client.Connected)
                    break;
                string msg = "";
                byte[] dt = new byte[1024 * 8000];
                do
                {
                    bytesReceived = client.Receive(dt);
                    msg += Encoding.ASCII.GetString(dt, 0, bytesReceived);
                } while (bytesReceived > 0 && msg[msg.Length - 1] != '\n');
                if (msg == "")
                    break;
                AddMsg(msg);
            }
        }
        void AddMsg(string msg)
        {
            lst_received.Items.Add(msg + '\n');
        }

        void Connect()
        {
            int bytesReceived = 0;
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                //try
                //{
                while (true)
                {
                    server.Listen(100);
                    Socket client = server.Accept();
                    byte[] dt = new byte[1024 * 8000];
                    if (!client.Connected)
                        break;
                    string msg = "";
                    do
                    {
                        bytesReceived = client.Receive(dt);
                        msg += Encoding.ASCII.GetString(dt, 0, bytesReceived);
                    } while (bytesReceived > 0 && msg[msg.Length - 1] != '\n');
                    if (msg == "")
                        break;
                    AddMsg(msg);
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(client);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
