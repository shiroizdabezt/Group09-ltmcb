using Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnMulTCPServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                MulTCPServer s = new MulTCPServer();
                s.ShowDialog();
            });
            thread.Start();
            btnMulTCPServer.Enabled = false;
        }

        private void btnMulTCPClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                MulTCPClient c = new MulTCPClient();
                c.ShowDialog();
            });
            thread.Start();
        }
    }
}
