using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using static Lab4.Bai4;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        public static HttpClient client = new HttpClient();
        public static string url = "https://reqres.in/api/users?page=1";

        public class Data
        {
            public int id { get; set; }
            public string email { get; set; } = string.Empty;
            public string first_name { get; set; } = string.Empty;
            public string last_name { get; set; } = string.Empty;
            public string avatar { get; set; } = string.Empty;
        }
        public class UserList
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public Data[] data { get; set; }
        }

        private async void GetAsync(string url)
        {

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<UserList>(jsonResponse);
                lb_page_number.Text = users.page.ToString();
                lb_total_page.Text = users.total_pages.ToString();
                lb_total_user.Text = users.total.ToString();
                lb_user_per_page.Text = users.per_page.ToString();


                foreach (var user in users.data)
                {
                    Panel userPanel = new Panel();
                    userPanel.BorderStyle = BorderStyle.FixedSingle;
                    userPanel.Width = 850;
                    userPanel.Height = 80;
                    userPanel.AutoScroll = true;
                    flp_lists.Controls.Add(userPanel);

                    // add a full name label to flp
                    Label fullNameLabel = new Label();
                    fullNameLabel.Text = user.first_name + " " + user.last_name;
                    fullNameLabel.AutoSize = true;
                    fullNameLabel.Font = new Font(fullNameLabel.Font, FontStyle.Bold);
                    userPanel.Controls.Add(fullNameLabel);


                    // Add an email label to flp
                    Label emailLabel = new Label();
                    emailLabel.Text = user.email;
                    emailLabel.AutoSize = true;
                    emailLabel.Top = fullNameLabel.Bottom + 5;
                    userPanel.Controls.Add(emailLabel);

                    // Add a picture box to flp
                    PictureBox avatarBox = new PictureBox();
                    avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    avatarBox.Width = 70;
                    avatarBox.Height = 70;
                    avatarBox.Left = userPanel.Width - avatarBox.Width - 5;
                    userPanel.Controls.Add(avatarBox);

                    // Load the user's avatar image
                    var request = WebRequest.Create(user.avatar);
                    using (var responses = request.GetResponse())
                    using (var stream = responses.GetResponseStream())
                    {
                        avatarBox.Image = Bitmap.FromStream(stream);
                    }

                }
            }

        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            GetAsync(url);
        }

        private void bt_forward_Click(object sender, EventArgs e)
        {
            string url2 = "https://reqres.in/api/users?page=2";
            flp_lists.Controls.Clear();
            GetAsync(url2);
        }

        private void bt_backward_Click(object sender, EventArgs e)
        {
            flp_lists.Controls.Clear();
            GetAsync(url);
        }
    }
}
