using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BTTuan3
{
    public partial class UDPClient : Form
    {
        Socket socket;
        IPEndPoint endpoint;
        byte[] buffer = new byte[1024];
        public UDPClient()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            int Port = Int32.Parse(txtPort.Text);
            endpoint = new IPEndPoint(IPAddress.Parse(IP), Port);
            if (txtTinNhan.Text != "")
            {
                DateTime aDateTime = DateTime.Now;
                byte[] data = Encoding.UTF8.GetBytes(txtTen.Text + " [" + aDateTime + "]: " + txtTinNhan.Text);
                socket.SendTo(data, endpoint);
                listTinNhan.Items.Add(txtTen.Text + " [" + aDateTime + "]: " + txtTinNhan.Text);
                txtTinNhan.Text = String.Empty;
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(txtIP.Text, out ip))
                MessageBox.Show("Hãy nhập một IP chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Int32.Parse(txtPort.Text) < 1024 || Int32.Parse(txtPort.Text) > 65535)
                    MessageBox.Show("Hãy chọn một Port trong khoảng (1024-65535)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtTen.Text == string.Empty)
                        MessageBox.Show("Hãy nhập tên cho máy khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
