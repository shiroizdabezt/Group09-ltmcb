using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IPEndPoint IP;
        Socket client;

        void Connection()
        {
            IPAddress ip;
            ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            IP = new IPEndPoint(ip, 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Unable to connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send()
        {
            if (txtMess.Text != string.Empty)
                client.Send(Serialize(txtMess.Text));
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] dt = new byte[1024 * 8000];
                    client.Receive(dt);
                    string message = (string)Deserialize(dt);
                    lstReceived.Items.Insert(0, message);
                }
            }
            catch
            {
                Close();
            }
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }
        void Disconnect()
        {
            if (client != null && client.Connected)
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
