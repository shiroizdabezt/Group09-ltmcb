namespace Lab3
{
    partial class Bai4
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
            btnMulTCPServer=new Button();
            btnMulTCPClient=new Button();
            SuspendLayout();
            // 
            // btnMulTCPServer
            // 
            btnMulTCPServer.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulTCPServer.Location=new Point(25, 49);
            btnMulTCPServer.Name="btnMulTCPServer";
            btnMulTCPServer.Size=new Size(127, 36);
            btnMulTCPServer.TabIndex=0;
            btnMulTCPServer.Text="TCPServer";
            btnMulTCPServer.UseVisualStyleBackColor=true;
            btnMulTCPServer.Click+=btnMulTCPServer_Click;
            // 
            // btnMulTCPClient
            // 
            btnMulTCPClient.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulTCPClient.Location=new Point(191, 49);
            btnMulTCPClient.Name="btnMulTCPClient";
            btnMulTCPClient.Size=new Size(127, 36);
            btnMulTCPClient.TabIndex=1;
            btnMulTCPClient.Text="MulTCPClient";
            btnMulTCPClient.UseVisualStyleBackColor=true;
            btnMulTCPClient.Click+=btnMulTCPClient_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(345, 143);
            Controls.Add(btnMulTCPClient);
            Controls.Add(btnMulTCPServer);
            Name="Bai4";
            Text="Bai4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMulTCPServer;
        private Button btnMulTCPClient;
    }
}