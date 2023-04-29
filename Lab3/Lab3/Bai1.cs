using BTTuan3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDP_Server;

namespace Lab3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_UDPServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPServer s = new UDPServer();
                s.ShowDialog();
            });
            thread.Start();
            btn_UDPServer.Enabled = false;
        }

        private void btn_UDPClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPClient c = new UDPClient();
                c.ShowDialog();
            });
            thread.Start();
            btn_UDPClient.Enabled = false;
        }
    }
}
