﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4(); 
            bai4.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Choose_Protocol cp = new Choose_Protocol();
            cp.Show();
        }
    }
}
