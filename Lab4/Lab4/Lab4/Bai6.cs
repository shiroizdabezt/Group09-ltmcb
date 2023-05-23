using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace Lab4
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        class News
        {
            public string title;
            public string description;
            public string Url;
            public string imgUrl;
            public int id;
        }

        void DisplayNews(News news)
        {
            //Định dạng tiêu đề bài báo
            Label lbTitle = new Label();
            lbTitle.Text = news.title;
            lbTitle.Font = new Font("Serif", 10, FontStyle.Bold);
            lbTitle.Location = new Point(0, (news.id - 2) * 110);
            lbTitle.Size = new Size(panel1.Width - 125, 90);

            //Định dạng mô tả bài báo
            Label lbDescription = new Label();
            lbDescription.Text = news.description;
            lbDescription.Location = new Point(0, lbTitle.Location.Y + 35);
            lbDescription.Size = new Size(panel1.Width - 175, 50);

            //Căn chỉnh kích thước hình ảnh bài báo
            PictureBox picture = new PictureBox();
            picture.LoadAsync(news.imgUrl);
            picture.Size = new Size(120, lbTitle.Size.Height - 10);
            picture.Location = new Point(panel1.Width - 120, lbTitle.Location.Y);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            //Xử lý sự kiện click vào một bài báo
            lbTitle.Click += delegate (object sender, EventArgs e)
            {
                DisplayChosenNews(sender, e, news.Url);
            };
            lbDescription.Click += delegate (object sender, EventArgs e)
            {
                DisplayChosenNews(sender, e, news.Url);
            };
            picture.Click += delegate (object sender, EventArgs e)
            {
                DisplayChosenNews(sender, e, news.Url);
            };

            lbTitle.Cursor = Cursors.Hand;
            lbDescription.Cursor = Cursors.Hand;
            picture.Cursor = Cursors.Hand;

            //Hiển thị các thuộc tính được chọn của bài báo lên panel
            panel1.Controls.Add(picture);
            panel1.Controls.Add(lbDescription);
            panel1.Controls.Add(lbTitle);
            panel1.AutoScroll = true;
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            //Lấy nội dung HTML của trang web dựa theo đường link đã cho
            HtmlWeb htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(txt_link.Text);

            //Lấy ra tag gốc của tiêu đề
            var articles = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");

            int id = 0;
            foreach (var article in articles)
            {
                // tag bắt đầu và kết thúc của tiêu đề
                var title = article?.SelectSingleNode("./h2")?.InnerText.Trim();
                if (title != null)
                {
                    //tag bắt đầu và kết thúc của mô tả, hình, đường link
                    var description = article.SelectSingleNode("./p").InnerText.Trim();
                    var imgUrl = article.SelectSingleNode("./div/a/picture/img").Attributes["src"].Value;
                    var Url = article.SelectSingleNode("./h2/a").Attributes["href"].Value;

                    if (!imgUrl.StartsWith("https"))
                        imgUrl = article.SelectSingleNode("./div/a/picture/img").Attributes["data-src"].Value;
                    News tmp = new News();
                    tmp.title = title;
                    tmp.description = description;
                    tmp.imgUrl = imgUrl;
                    tmp.Url = Url;
                    tmp.id = id;

                    DisplayNews(tmp);

                    id++;
                }
            }
        }

        private void DisplayChosenNews(object sender, EventArgs e, string url)
        {
            int i;
            Bai6Show b6_show = new Bai6Show(url);
            //tăng % của thanh progress bar
            for (i = 0; i < 101; i++)
                progressBar1.Increment(i);

            //khi click vào một liên kết bài báo thì thanh progressbar sẽ chạy
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer1.Stop();
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                b6_show.Show();
            }
        }
    }
}
