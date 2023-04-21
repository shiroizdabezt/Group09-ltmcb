using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class TodoTask
        {
            public int userID { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
           
        }
        public class Comments
        {
            public int postID { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string body { get; set; }
        }
        public class Albums
        {
            public int userID { get; set; }
            public int id { get; set; }
            public string title { get; set; }
        }

        public static HttpClient client = new HttpClient();

        private void DisplayTodoList(List<TodoTask> task)
        {
            dgv_display.DataSource = null;
            dgv_display.Rows.Clear();
            dgv_display.DataSource = task;
        }

        private void DisplayComments(List<Comments> task)
        {
            dgv_display.DataSource = null;
            dgv_display.Rows.Clear();
            dgv_display.DataSource = task;
        }
        private void DisplayAlbums(List<Albums> task)
        {
            dgv_display.DataSource = null;
            dgv_display.Rows.Clear();
            dgv_display.DataSource = task;
        }

        private async void GetTasksAsync()
        {
            HttpResponseMessage response = await client.GetAsync(cbbAPI.Text);
            switch (cbbAPI.Text)
            {
                case "https://jsonplaceholder.typicode.com/todos":
                    if (response.IsSuccessStatusCode)
                    {
                        List<TodoTask> task = await response.Content.ReadAsAsync<List<TodoTask>>();
                        DisplayTodoList(task);
                        MessageBox.Show("Successful!");
                    }
                    else
                        MessageBox.Show("Fail!");
                    break;
                case "https://jsonplaceholder.typicode.com/comments":
                    if (response.IsSuccessStatusCode)
                    {
                        List<Comments> task = await response.Content.ReadAsAsync<List<Comments>>();
                        DisplayComments(task);
                        MessageBox.Show("Successful!");
                    }
                    else
                        MessageBox.Show("Fail!");
                    break;
                case "https://jsonplaceholder.typicode.com/albums":
                    if (response.IsSuccessStatusCode)
                    {
                        List<Albums> task = await response.Content.ReadAsAsync<List<Albums>>();
                        DisplayAlbums(task);
                        MessageBox.Show("Successful!");
                    }
                    else
                        MessageBox.Show("Fail!");
                    break;
            }    
            
        }
        private void bt_get_Click(object sender, EventArgs e)
        {
            GetTasksAsync();
        }
    }
}
