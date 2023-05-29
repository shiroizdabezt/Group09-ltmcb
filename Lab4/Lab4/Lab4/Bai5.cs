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
        HttpClient httpClient = new HttpClient();
        public Bai5()
        {
            InitializeComponent();

            rtxtToken.ReadOnly = true;

            txtEmail.Text = "eve.holt@reqres.in";
            txtPassword.Text = "pistol";

            txtEmail.TextChanged += rtxtToken_TextChanged;
            txtPassword.TextChanged += rtxtToken_TextChanged;
        }
        private class API
        {
            public string key { get; set; }
            public string token { get; set; }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Task.Run(() => postData());
        }

        private async void postData()
        {
            try
            {
                var data = new Dictionary<string, string>
            {
                { "email",  txtEmail.Text},
                { "password",  txtPassword.Text}
            };

                var content = new FormUrlEncodedContent(data);

                HttpResponseMessage response = await httpClient.PostAsync(txtUrl.Text, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    API user = JsonConvert.DeserializeObject<API>(responseBody);
                    appendData(user.token);
                }
            }
            catch (Exception ex)
            {
                appendData($"Error from getting HTTP response! {ex.Message}");
            }
        }

        private void appendData(string responseBody)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => appendData(responseBody)));
            }
            else
            {
                rtxtToken.Clear();
                rtxtToken.Text += responseBody;
            }
        }

        private void rtxtToken_TextChanged(object sender, EventArgs e)
        {
            bool isFullFilled = !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text);
            btnPost.Enabled = isFullFilled;
        }

        private void btnPost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPost_Click(sender, e);
            }
        }
    }
}
