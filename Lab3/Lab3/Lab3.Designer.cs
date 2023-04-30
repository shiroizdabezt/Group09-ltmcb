namespace Lab3
{
    partial class Lab3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Bai1 = new Button();
            btn_Bai2 = new Button();
            btn_Bai3 = new Button();
            btn_Bai4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(397, 87);
            label1.Name = "label1";
            label1.Size = new Size(104, 46);
            label1.TabIndex = 0;
            label1.Text = "LAB3";
            // 
            // btn_Bai1
            // 
            btn_Bai1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Bai1.Location = new Point(206, 236);
            btn_Bai1.Margin = new Padding(3, 4, 3, 4);
            btn_Bai1.Name = "btn_Bai1";
            btn_Bai1.Size = new Size(111, 51);
            btn_Bai1.TabIndex = 1;
            btn_Bai1.Text = "Bài 1";
            btn_Bai1.UseVisualStyleBackColor = true;
            btn_Bai1.Click += btn_Bai1_Click;
            // 
            // btn_Bai2
            // 
            btn_Bai2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Bai2.Location = new Point(206, 391);
            btn_Bai2.Margin = new Padding(3, 4, 3, 4);
            btn_Bai2.Name = "btn_Bai2";
            btn_Bai2.Size = new Size(111, 51);
            btn_Bai2.TabIndex = 2;
            btn_Bai2.Text = "Bài 2";
            btn_Bai2.UseVisualStyleBackColor = true;
            btn_Bai2.Click += btn_Bai2_Click;
            // 
            // btn_Bai3
            // 
            btn_Bai3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Bai3.Location = new Point(561, 236);
            btn_Bai3.Margin = new Padding(3, 4, 3, 4);
            btn_Bai3.Name = "btn_Bai3";
            btn_Bai3.Size = new Size(111, 51);
            btn_Bai3.TabIndex = 3;
            btn_Bai3.Text = "Bài 3";
            btn_Bai3.UseVisualStyleBackColor = true;
            btn_Bai3.Click += btn_Bai3_Click;
            // 
            // btn_Bai4
            // 
            btn_Bai4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Bai4.Location = new Point(561, 391);
            btn_Bai4.Margin = new Padding(3, 4, 3, 4);
            btn_Bai4.Name = "btn_Bai4";
            btn_Bai4.Size = new Size(111, 51);
            btn_Bai4.TabIndex = 4;
            btn_Bai4.Text = "Bài 4";
            btn_Bai4.UseVisualStyleBackColor = true;
            btn_Bai4.Click += btn_Bai4_Click;
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_Bai4);
            Controls.Add(btn_Bai3);
            Controls.Add(btn_Bai2);
            Controls.Add(btn_Bai1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab3";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Bai1;
        private Button btn_Bai2;
        private Button btn_Bai3;
        private Button btn_Bai4;
    }
}