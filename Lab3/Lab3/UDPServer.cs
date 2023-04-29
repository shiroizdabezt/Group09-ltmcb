using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace UDP_Server
{
    public partial class UDPServer : Form
    {
        Socket socket;
        byte[] buffer = new byte[1024];
        EndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
        public UDPServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(txtIP.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(txtPort.Text) < 1024 || Int32.Parse(txtPort.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), Int32.Parse(txtPort.Text));
                    socket.Bind(IPendpoint);
                    Thread listen = new Thread(Receive);
                    listen.IsBackground = true;
                    listen.Start();
                    MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void Receive()
        {
            while (true)
            {
                string received_data;
                socket.ReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref endpoint);
                received_data = Encoding.UTF8.GetString(buffer);
                listTinNhan.Items.Add(Text = received_data);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
