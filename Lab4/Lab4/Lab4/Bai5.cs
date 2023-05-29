using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        int index;
        UserPagination data;
        public Bai5()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            var url = "https://reqres.in/api/users?page=1";
            LoadPage(data, url);
            btGet.Visible = false;
            btNext.Enabled = true;
        }

        private void LoadPage(UserPagination data, string url)
        {
            var res = getHTML(url);
            data = JsonSerializer.Deserialize<UserPagination>(res);
            var total = data.Total;

            lbPage.Text = "Page: " + data.Page;
            lbUser.Text = "User: " + data.PerPage;
            lbTotalPage.Text = "Total Page: " + data.TotalPages;
            lbTotalUsers.Text = "Total Users: " + data.Total;

            int count = 0;

            foreach (var item in data.Data)
            {
                Label lbName = new Label();
                lbName.Text = item.FirstName + " " + item.LastName;
                lbName.Location = new Point(0, ((item.Id - 1) % data.PerPage) * 120);
                lbName.Size = new Size(panel1.Width, 100);
                lbName.BorderStyle = BorderStyle.FixedSingle;

                Label lbEmail = new Label();
                lbEmail.Text = item.Email;
                lbEmail.Location = new Point(3, lbName.Location.Y + 20);
                lbEmail.Size = new Size(150, 20);
                lbName.BringToFront();

                PictureBox picture = new PictureBox();
                picture.LoadAsync(item.Avatar);
                picture.Size = new Size(120, lbName.Height - 10);
                picture.Location = new Point(panel1.Width - 160, lbName.Location.Y + 5);
                picture.SizeMode = PictureBoxSizeMode.CenterImage;

                panel1.Controls.Add(picture);
                panel1.Controls.Add(lbEmail);
                panel1.Controls.Add(lbName);

                count++;

                progressBar.Invoke(new Action(() => progressBar.Value = (int)(((double)count / data.Data.Count()) * 100)));

            }

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            index = 1;
            panel1.Controls.Clear();
            string url = "https://reqres.in/api/users?page=1";
            LoadPage(data, url);
            btBack.Enabled = false;
            btNext.Enabled = true;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            index = 2;
            panel1.Controls.Clear();
            string url = "https://reqres.in/api/users?page=2";
            LoadPage(data, url);
            btNext.Enabled = false;
            btBack.Enabled = true;
        }
    }
}
