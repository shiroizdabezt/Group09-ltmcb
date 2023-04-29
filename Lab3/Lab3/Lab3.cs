namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
        }
    }
}