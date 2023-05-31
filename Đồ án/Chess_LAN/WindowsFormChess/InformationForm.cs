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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassForm change = new ChangePassForm();
            change.ShowDialog();  
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }
    }
}
