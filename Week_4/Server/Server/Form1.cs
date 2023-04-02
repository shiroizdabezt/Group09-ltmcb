using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.Mime.MediaTypeNames;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hàm nhận tin nhắn 
        void Receive(Socket client)
        {
            try
            {
                while(true)
                {
                    byte[] dt = new byte[1024 * 8000];
                    client.Receive(dt);



                    string msg = (string)Deserialize(dt);

                    AddMsg(msg);
                }    
            }
            catch 
            {
                Close();
            }
        }
        void AddMsg(string msg) 
        {
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();


            binaryFormatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //Hàm gom mảnh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();


            return binaryFormatter.Deserialize(stream);
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {

        }
    }
}
