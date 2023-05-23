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
    public partial class Bai6Show : Form
    {
        WebBrowser webBrowser1 = new WebBrowser();
        public Bai6Show(string url)
        {
            InitializeComponent();
            //webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Url = new Uri(url);
            webBrowser1.ScriptErrorsSuppressed = true; //phớt lờ lỗi ScriptError
            webBrowser1.Width = 859;
            webBrowser1.Height = 505;
            //Hiển thị trang web lên panel của form
            pnInf.Controls.Add(webBrowser1);
        }
    }
}
