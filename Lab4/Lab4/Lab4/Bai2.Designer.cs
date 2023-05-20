namespace Lab4
{
    partial class Bai2
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
            txtURL=new TextBox();
            btnDownload=new Button();
            txtData=new RichTextBox();
            txtFilePath=new TextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location=new Point(24, 30);
            txtURL.Name="txtURL";
            txtURL.Size=new Size(532, 23);
            txtURL.TabIndex=0;
            // 
            // btnDownload
            // 
            btnDownload.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownload.Location=new Point(562, 30);
            btnDownload.Name="btnDownload";
            btnDownload.Size=new Size(123, 52);
            btnDownload.TabIndex=2;
            btnDownload.Text="Download";
            btnDownload.UseVisualStyleBackColor=true;
            btnDownload.Click+=btnDownload_Click;
            // 
            // txtData
            // 
            txtData.Location=new Point(12, 103);
            txtData.Name="txtData";
            txtData.Size=new Size(673, 432);
            txtData.TabIndex=3;
            txtData.Text="";
            // 
            // txtFilePath
            // 
            txtFilePath.Location=new Point(24, 59);
            txtFilePath.Name="txtFilePath";
            txtFilePath.Size=new Size(532, 23);
            txtFilePath.TabIndex=4;
            // 
            // Bai2
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(697, 547);
            Controls.Add(txtFilePath);
            Controls.Add(txtData);
            Controls.Add(btnDownload);
            Controls.Add(txtURL);
            Name="Bai2";
            Text="Bai2";
            Load+=Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnDownload;
        private RichTextBox txtData;
        private TextBox txtFilePath;
    }
}