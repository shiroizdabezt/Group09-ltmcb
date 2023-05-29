namespace Lab4
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
            lb_page = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_page_number = new Label();
            lb_user_per_page = new Label();
            lb_total_page = new Label();
            lb_total_user = new Label();
            label4 = new Label();
            bt_backward = new Button();
            bt_forward = new Button();
            flp_lists = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Location = new Point(12, 9);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(44, 20);
            lb_page.TabIndex = 1;
            lb_page.Text = "Page:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "User/Page:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Total User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 9);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Total Page:";
            // 
            // lb_page_number
            // 
            lb_page_number.AutoSize = true;
            lb_page_number.Location = new Point(62, 9);
            lb_page_number.Name = "lb_page_number";
            lb_page_number.Size = new Size(17, 20);
            lb_page_number.TabIndex = 5;
            lb_page_number.Text = "1";
            // 
            // lb_user_per_page
            // 
            lb_user_per_page.AutoSize = true;
            lb_user_per_page.Location = new Point(97, 55);
            lb_user_per_page.Name = "lb_user_per_page";
            lb_user_per_page.Size = new Size(17, 20);
            lb_user_per_page.TabIndex = 6;
            lb_user_per_page.Text = "1";
            // 
            // lb_total_page
            // 
            lb_total_page.AutoSize = true;
            lb_total_page.Location = new Point(373, 9);
            lb_total_page.Name = "lb_total_page";
            lb_total_page.Size = new Size(17, 20);
            lb_total_page.TabIndex = 7;
            lb_total_page.Text = "1";
            // 
            // lb_total_user
            // 
            lb_total_user.AutoSize = true;
            lb_total_user.Location = new Point(373, 55);
            lb_total_user.Name = "lb_total_user";
            lb_total_user.Size = new Size(17, 20);
            lb_total_user.TabIndex = 8;
            lb_total_user.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(539, 33);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "User List";
            // 
            // bt_backward
            // 
            bt_backward.Location = new Point(439, 29);
            bt_backward.Name = "bt_backward";
            bt_backward.Size = new Size(94, 29);
            bt_backward.TabIndex = 10;
            bt_backward.Text = "<<";
            bt_backward.UseVisualStyleBackColor = true;
            bt_backward.Click += bt_backward_Click;
            // 
            // bt_forward
            // 
            bt_forward.Location = new Point(615, 29);
            bt_forward.Name = "bt_forward";
            bt_forward.Size = new Size(94, 29);
            bt_forward.TabIndex = 11;
            bt_forward.Text = ">>";
            bt_forward.UseVisualStyleBackColor = true;
            bt_forward.Click += bt_forward_Click;
            // 
            // flp_lists
            // 
            flp_lists.AutoScroll = true;
            flp_lists.Location = new Point(12, 102);
            flp_lists.Name = "flp_lists";
            flp_lists.Size = new Size(870, 402);
            flp_lists.TabIndex = 12;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 516);
            Controls.Add(flp_lists);
            Controls.Add(bt_forward);
            Controls.Add(bt_backward);
            Controls.Add(label4);
            Controls.Add(lb_total_user);
            Controls.Add(lb_total_page);
            Controls.Add(lb_user_per_page);
            Controls.Add(lb_page_number);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_page);
            Name = "Bai4";
            Text = "Form1";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_page;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_page_number;
        private Label lb_user_per_page;
        private Label lb_total_page;
        private Label lb_total_user;
        private Label label4;
        private Button bt_backward;
        private Button bt_forward;
        private FlowLayoutPanel flp_lists;
    }
}