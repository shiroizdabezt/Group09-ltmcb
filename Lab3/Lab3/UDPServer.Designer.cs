namespace UDP_Server
{
    partial class UDPServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTinNhan=new ListBox();
            groupBox1=new GroupBox();
            btnTao=new Button();
            txtPort=new TextBox();
            txtIP=new TextBox();
            label2=new Label();
            label1=new Label();
            btnThoat=new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listTinNhan
            // 
            listTinNhan.FormattingEnabled=true;
            listTinNhan.ItemHeight=15;
            listTinNhan.Location=new Point(14, 14);
            listTinNhan.Margin=new Padding(4, 3, 4, 3);
            listTinNhan.Name="listTinNhan";
            listTinNhan.Size=new Size(443, 454);
            listTinNhan.TabIndex=0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTao);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location=new Point(484, 14);
            groupBox1.Margin=new Padding(4, 3, 4, 3);
            groupBox1.Name="groupBox1";
            groupBox1.Padding=new Padding(4, 3, 4, 3);
            groupBox1.Size=new Size(292, 198);
            groupBox1.TabIndex=3;
            groupBox1.TabStop=false;
            groupBox1.Text="Tạo thông tin cho Máy chủ";
            // 
            // btnTao
            // 
            btnTao.Location=new Point(104, 147);
            btnTao.Margin=new Padding(4, 3, 4, 3);
            btnTao.Name="btnTao";
            btnTao.Size=new Size(88, 27);
            btnTao.TabIndex=4;
            btnTao.Text="Tạo";
            btnTao.UseVisualStyleBackColor=true;
            btnTao.Click+=btnTao_Click;
            // 
            // txtPort
            // 
            txtPort.Location=new Point(134, 95);
            txtPort.Margin=new Padding(4, 3, 4, 3);
            txtPort.Name="txtPort";
            txtPort.Size=new Size(116, 23);
            txtPort.TabIndex=3;
            txtPort.Text="8080";
            // 
            // txtIP
            // 
            txtIP.Location=new Point(134, 54);
            txtIP.Margin=new Padding(4, 3, 4, 3);
            txtIP.Name="txtIP";
            txtIP.Size=new Size(116, 23);
            txtIP.TabIndex=2;
            txtIP.Text="127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(36, 98);
            label2.Margin=new Padding(4, 0, 4, 0);
            label2.Name="label2";
            label2.Size=new Size(88, 15);
            label2.TabIndex=1;
            label2.Text="Cổng máy chủ:";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(36, 58);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(69, 15);
            label1.TabIndex=0;
            label1.Text="IP máy chủ:";
            // 
            // btnThoat
            // 
            btnThoat.Location=new Point(588, 430);
            btnThoat.Margin=new Padding(4, 3, 4, 3);
            btnThoat.Name="btnThoat";
            btnThoat.Size=new Size(88, 27);
            btnThoat.TabIndex=4;
            btnThoat.Text="Thoát";
            btnThoat.UseVisualStyleBackColor=true;
            btnThoat.Click+=btnThoat_Click;
            // 
            // UDPServer
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(803, 482);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(listTinNhan);
            Margin=new Padding(4, 3, 4, 3);
            Name="UDPServer";
            Text="Máy chủ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listTinNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}

