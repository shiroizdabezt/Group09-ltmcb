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
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InGameForm newGame = new InGameForm(false,false,textBox1.Text);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InGameForm newGame = new InGameForm(false, true);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }
    }
}
