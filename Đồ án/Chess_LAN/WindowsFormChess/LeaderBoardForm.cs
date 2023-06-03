using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Group9
{
    public partial class LeaderBoardForm : Form
    {
        static public string username = Loging.name;
        static public string sdt = Loging.phonenumber;
        int top = 1;
        public LeaderBoardForm()
        {
            InitializeComponent();
        }

        private async void LeaderBoardForm_Load(object sender, EventArgs e)
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://chess-18b37-default-rtdb.asia-southeast1.firebasedatabase.app/");

            // Lấy tham chiếu đến đường dẫn dữ liệu bạn muốn truy vấn
            var dataRef = firebaseClient.Child("");

            // Lấy danh sách dữ liệu từ Firebase
            var dataSnapshot = await dataRef.OnceAsync<SignUpInformation>();

            // Sắp xếp danh sách theo trường "score" theo thứ tự giảm dần
            var orderedData = dataSnapshot.OrderBy(d => d.Object.score).Reverse().Take(10);

            // Tạo một danh sách để chứa dữ liệu từ Firebase
            List<SignUpInformation> dataList = new List<SignUpInformation>();

            // Lặp qua dữ liệu đã sắp xếp và thêm vào danh sách
            foreach (var item in orderedData)
            {
                dataList.Add(item.Object);
            }

            // Gán dữ liệu vào ListView
            for (int i = 0; i < dataList.Count - 1; i++)
            {
                ListViewItem listViewItem = new ListViewItem(top.ToString());
                listViewItem.SubItems.Add(dataList[i].name);
                listViewItem.SubItems.Add(dataList[i].score.ToString());
                listViewItem.SubItems.Add(dataList[i].match.ToString());
                double winrate = ((double)dataList[i].win_match / dataList[i].match) * 100;
                string winrate3 = winrate.ToString("F1");
                listViewItem.SubItems.Add(winrate3 + "%");
                listRank.Items.Add(listViewItem);
                // Xử lý đồng hạng
                if (dataList[i].score != dataList[i + 1].score)
                {
                    top = i + 2;
                }
            }
            // Xử lý vị trí thứ 10
            if (dataList[9].score != dataList[8].score)
                top = 10;
            ListViewItem lsv = new ListViewItem(top.ToString());
            lsv.SubItems.Add(dataList[9].name);
            lsv.SubItems.Add(dataList[9].score.ToString());
            lsv.SubItems.Add(dataList[9].match.ToString());
            double winrate1 = ((double)dataList[9].win_match / dataList[9].match) * 100;
            string winrate2 = winrate1.ToString("F1");
            lsv.SubItems.Add(winrate2 + "%");
            listRank.Items.Add(lsv);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }

        private void listRank_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.listRank.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
