﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Threading;
=======
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.Mime.MediaTypeNames;
>>>>>>> origin/main

namespace Server
{
    public partial class Form1 : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        public void Send()
=======
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
>>>>>>> origin/main
        {
            
        }

<<<<<<< HEAD
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 0);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 0);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                }
            });
            Listen.IsBackground = true;
            Listen.Start();
=======
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

>>>>>>> origin/main
        }
    }
}
