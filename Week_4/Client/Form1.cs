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
            send.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IPEndPoint IP;
        Socket client;

        void Connection()
        {
            IP = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), Int32.Parse(txt_Port.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
                MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send()
        {
            if (txtMess.Text != string.Empty)
            {
                DateTime dtime = DateTime.Now;
                client.Send(Serialize(txt_Username.Text + " [" + dtime.ToString() + "]: " + txtMess.Text));
                lstReceived.Items.Add(txt_Username.Text + " [" + dtime.ToString() + "]: " + txtMess.Text);
            }    
                
            txtMess.Clear();
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
                    lstReceived.Items.Add(message);
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
                MessageBox.Show("Ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                send.Enabled = false;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            Connection();
            send.Enabled = true;
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
