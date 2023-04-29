using Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDP_Server;

namespace Lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPServer s = new TCPServer();
                s.ShowDialog();
            });
            thread.Start();
            btnTCPServer.Enabled = false;
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPClient c = new TCPClient();
                c.ShowDialog();
            });
            thread.Start();
            btnTCPClient.Enabled = false;
        }
    }
}
