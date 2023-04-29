namespace Lab3
{
    partial class Bai1
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
            btn_UDPServer=new Button();
            btn_UDPClient=new Button();
            SuspendLayout();
            // 
            // btn_UDPServer
            // 
            btn_UDPServer.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UDPServer.Location=new Point(27, 50);
            btn_UDPServer.Name="btn_UDPServer";
            btn_UDPServer.Size=new Size(127, 36);
            btn_UDPServer.TabIndex=0;
            btn_UDPServer.Text="UDP Server";
            btn_UDPServer.UseVisualStyleBackColor=true;
            btn_UDPServer.Click+=btn_UDPServer_Click;
            // 
            // btn_UDPClient
            // 
            btn_UDPClient.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UDPClient.Location=new Point(189, 50);
            btn_UDPClient.Name="btn_UDPClient";
            btn_UDPClient.Size=new Size(127, 36);
            btn_UDPClient.TabIndex=1;
            btn_UDPClient.Text="UDP Client";
            btn_UDPClient.UseVisualStyleBackColor=true;
            btn_UDPClient.Click+=btn_UDPClient_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(345, 143);
            Controls.Add(btn_UDPClient);
            Controls.Add(btn_UDPServer);
            Name="Bai1";
            Text="Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UDPServer;
        private Button btn_UDPClient;
    }
}