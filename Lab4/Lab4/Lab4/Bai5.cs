using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http;
using Newtonsoft.Json;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        // Khai báo đối tượng httpClient của lớp HttpClient
        HttpClient httpClient = new HttpClient();
        public Bai5()
        {
            InitializeComponent();

            // Thiết lập thuộc tính ReadOnly của rtxtToken là true
            rtxtToken.ReadOnly = true;

            // Gán sự kiện rtxtToken_TextChanged cho sự kiện TextChanged của các textbox Email và Password
            txtEmail.TextChanged += rtxtToken_TextChanged;
            txtPassword.TextChanged += rtxtToken_TextChanged;
        }

        // Lớp API để lưu trữ giá trị của các thuộc tính key và token
        private class API
        {
            public string key { get; set; }
            public string token { get; set; }
        }

        // Hàm xử lý sự kiện click của nút btnPost
        private void btnPost_Click(object sender, EventArgs e)
        {
            // Gọi hàm postData() trong một task để xử lý bất đồng bộ
            Task.Run(() => postData());
        }

        // Hàm xử lý dữ liệu khi gửi yêu cầu POST đến API
        private async void postData()
        {
            try
            {
                // Tạo một dictionary để chứa dữ liệu email và password
                var data = new Dictionary<string, string>
            {
                { "email",  txtEmail.Text},
                { "password",  txtPassword.Text}
            };

                // Tạo nội dung content từ dictionary trên
                var content = new FormUrlEncodedContent(data);

                // Gửi yêu cầu POST đến API và nhận lại phản hồi từ server
                HttpResponseMessage response = await httpClient.PostAsync(txtUrl.Text, content);

                // Kiểm tra phản hồi từ server có thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi dưới dạng chuỗi
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Chuyển đổi chuỗi JSON thành đối tượng API và lấy giá trị của thuộc tính token
                    API user = JsonConvert.DeserializeObject<API>(responseBody);
                    appendData(user.token);
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra thì ghi log lỗi vào rtxtToken
                appendData($"Error from getting HTTP response! {ex.Message}");
            }
        }

        // Hàm thêm dữ liệu vào rtxtToken
        private void appendData(string responseBody)
        {
            if (InvokeRequired)
            {
                // Nếu đang chạy trên một thread khác thì gọi lại hàm này trên thread chính
                Invoke(new Action(() => appendData(responseBody)));
            }
            else
            {
                // Xóa dữ liệu cũ trong rtxtToken và thêm dữ liệu mới
                rtxtToken.Clear();
                rtxtToken.Text += responseBody;
            }
        }

        // Hàm xử lý sự kiện TextChanged của các textbox Email và Password
        private void rtxtToken_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem các textbox Email và Password đã được điền đầy đủ thông tin hay chưa
            bool isFullFilled = !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text);

            // Thiết lập thuộc tính Enabled của nút btnPost dựa trên kết quả kiểm tra trên
            btnPost.Enabled = isFullFilled;
        }

        // Hàm xử lý sự kiện KeyDown của nút btnPost
        private void btnPost_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu phím nhấn là phím Enter thì gọi lại hàm xử lý sự kiện click của nút btnPost
            if (e.KeyCode == Keys.Enter)
            {
                btnPost_Click(sender, e);
            }
        }
    }
}
