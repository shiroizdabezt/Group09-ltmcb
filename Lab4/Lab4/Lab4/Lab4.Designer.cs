﻿namespace Lab4
{
    partial class Lab4
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
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            bntBai4 = new Button();
            btnBai5 = new Button();
            btnBai6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 67);
            label1.Name = "label1";
            label1.Size = new Size(104, 46);
            label1.TabIndex = 0;
            label1.Text = "LAB4";
            // 
            // btnBai1
            // 
            btnBai1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai1.Location = new Point(131, 221);
            btnBai1.Margin = new Padding(3, 4, 3, 4);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(111, 67);
            btnBai1.TabIndex = 1;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai2.Location = new Point(361, 221);
            btnBai2.Margin = new Padding(3, 4, 3, 4);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(111, 67);
            btnBai2.TabIndex = 2;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai3.Location = new Point(131, 355);
            btnBai3.Margin = new Padding(3, 4, 3, 4);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(111, 67);
            btnBai3.TabIndex = 3;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // bntBai4
            // 
            bntBai4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bntBai4.Location = new Point(361, 355);
            bntBai4.Margin = new Padding(3, 4, 3, 4);
            bntBai4.Name = "bntBai4";
            bntBai4.Size = new Size(111, 67);
            bntBai4.TabIndex = 4;
            bntBai4.Text = "Bài 4";
            bntBai4.UseVisualStyleBackColor = true;
            bntBai4.Click += bntBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai5.Location = new Point(131, 497);
            btnBai5.Margin = new Padding(3, 4, 3, 4);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(111, 67);
            btnBai5.TabIndex = 5;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai6
            // 
            btnBai6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai6.Location = new Point(361, 497);
            btnBai6.Margin = new Padding(3, 4, 3, 4);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(111, 67);
            btnBai6.TabIndex = 6;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = true;
            btnBai6.Click += btnBai6_Click;
            // 
            // Lab4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 684);
            Controls.Add(btnBai6);
            Controls.Add(btnBai5);
            Controls.Add(bntBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab4";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button bntBai4;
        private Button btnBai5;
        private Button btnBai6;
    }
}