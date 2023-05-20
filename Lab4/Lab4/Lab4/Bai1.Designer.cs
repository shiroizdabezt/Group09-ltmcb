namespace Lab4
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
            txt_link = new TextBox();
            rtb_noidung = new RichTextBox();
            btn_Get = new Button();
            SuspendLayout();
            // 
            // txt_link
            // 
            txt_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_link.Location = new Point(12, 4);
            txt_link.Multiline = true;
            txt_link.Name = "txt_link";
            txt_link.Size = new Size(615, 48);
            txt_link.TabIndex = 0;
            // 
            // rtb_noidung
            // 
            rtb_noidung.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_noidung.Location = new Point(12, 58);
            rtb_noidung.Name = "rtb_noidung";
            rtb_noidung.Size = new Size(775, 371);
            rtb_noidung.TabIndex = 1;
            rtb_noidung.Text = "";
            // 
            // btn_Get
            // 
            btn_Get.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Get.Location = new Point(654, 4);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(133, 47);
            btn_Get.TabIndex = 2;
            btn_Get.Text = "GET";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Get);
            Controls.Add(rtb_noidung);
            Controls.Add(txt_link);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_link;
        private RichTextBox rtb_noidung;
        private Button btn_Get;
    }
}