namespace Lab3
{
    partial class Bai3
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
            btnTCPServer=new Button();
            btnTCPClient=new Button();
            SuspendLayout();
            // 
            // btnTCPServer
            // 
            btnTCPServer.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTCPServer.Location=new Point(27, 56);
            btnTCPServer.Name="btnTCPServer";
            btnTCPServer.Size=new Size(127, 36);
            btnTCPServer.TabIndex=0;
            btnTCPServer.Text="TCPServer";
            btnTCPServer.UseVisualStyleBackColor=true;
            btnTCPServer.Click+=btnTCPServer_Click;
            // 
            // btnTCPClient
            // 
            btnTCPClient.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTCPClient.Location=new Point(193, 56);
            btnTCPClient.Name="btnTCPClient";
            btnTCPClient.Size=new Size(127, 36);
            btnTCPClient.TabIndex=1;
            btnTCPClient.Text="TCPClient";
            btnTCPClient.UseVisualStyleBackColor=true;
            btnTCPClient.Click+=btnTCPClient_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(345, 143);
            Controls.Add(btnTCPClient);
            Controls.Add(btnTCPServer);
            Name="Bai3";
            Text="Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTCPServer;
        private Button btnTCPClient;
    }
}