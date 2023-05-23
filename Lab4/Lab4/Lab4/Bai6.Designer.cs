namespace Lab4
{
    partial class Bai6
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
            components=new System.ComponentModel.Container();
            txt_link=new TextBox();
            btn_Get=new Button();
            panel1=new Panel();
            progressBar1=new ProgressBar();
            timer1=new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txt_link
            // 
            txt_link.Location=new Point(50, 11);
            txt_link.Multiline=true;
            txt_link.Name="txt_link";
            txt_link.Size=new Size(678, 25);
            txt_link.TabIndex=0;
            txt_link.Text="https://vnexpress.net/the-gioi/tu-lieu";
            // 
            // btn_Get
            // 
            btn_Get.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Get.Location=new Point(734, 11);
            btn_Get.Name="btn_Get";
            btn_Get.Size=new Size(128, 25);
            btn_Get.TabIndex=1;
            btn_Get.Text="Get";
            btn_Get.UseVisualStyleBackColor=true;
            btn_Get.Click+=btn_Get_Click;
            // 
            // panel1
            // 
            panel1.Location=new Point(5, 42);
            panel1.Name="panel1";
            panel1.Size=new Size(866, 475);
            panel1.TabIndex=2;
            // 
            // progressBar1
            // 
            progressBar1.Location=new Point(5, 527);
            progressBar1.Name="progressBar1";
            progressBar1.Size=new Size(866, 23);
            progressBar1.TabIndex=3;
            // 
            // Bai6
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(883, 560);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(btn_Get);
            Controls.Add(txt_link);
            Name="Bai6";
            Text="Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_link;
        private Button btn_Get;
        private Panel panel1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}