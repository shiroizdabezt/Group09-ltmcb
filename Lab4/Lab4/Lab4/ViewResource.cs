using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ViewResource : Form
    {
        public ViewResource()
        {
            InitializeComponent();
        }

        private void ViewResource_Load(object sender, EventArgs e)
        {
            string downloadedContent = File.ReadAllText(Bai3.savedFilePath);
            rtb_view_resources.Text = downloadedContent;
        }


    }
}
