namespace Lab4
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
            bt_goback = new Button();
            bt_go = new Button();
            bt_download = new Button();
            pn_display = new Panel();
            tb_url = new TextBox();
            bt_view_resource = new Button();
            SuspendLayout();
            // 
            // bt_goback
            // 
            bt_goback.Location = new Point(442, 10);
            bt_goback.Name = "bt_goback";
            bt_goback.Size = new Size(41, 29);
            bt_goback.TabIndex = 2;
            bt_goback.Text = "<";
            bt_goback.UseVisualStyleBackColor = true;
            bt_goback.Click += bt_goback_Click;
            // 
            // bt_go
            // 
            bt_go.Location = new Point(489, 10);
            bt_go.Name = "bt_go";
            bt_go.Size = new Size(51, 31);
            bt_go.TabIndex = 3;
            bt_go.Text = "Go";
            bt_go.UseVisualStyleBackColor = true;
            bt_go.Click += bt_go_Click;
            // 
            // bt_download
            // 
            bt_download.Location = new Point(546, 10);
            bt_download.Name = "bt_download";
            bt_download.Size = new Size(98, 31);
            bt_download.TabIndex = 4;
            bt_download.Text = "download";
            bt_download.UseVisualStyleBackColor = true;
            bt_download.Click += bt_download_Click;
            // 
            // pn_display
            // 
            pn_display.Location = new Point(12, 66);
            pn_display.Name = "pn_display";
            pn_display.Size = new Size(749, 372);
            pn_display.TabIndex = 5;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(10, 12);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(426, 27);
            tb_url.TabIndex = 6;
            // 
            // bt_view_resource
            // 
            bt_view_resource.Location = new Point(650, 10);
            bt_view_resource.Name = "bt_view_resource";
            bt_view_resource.Size = new Size(120, 33);
            bt_view_resource.TabIndex = 7;
            bt_view_resource.Text = "View Resource";
            bt_view_resource.UseVisualStyleBackColor = true;
            bt_view_resource.Click += bt_view_resource_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_view_resource);
            Controls.Add(tb_url);
            Controls.Add(pn_display);
            Controls.Add(bt_download);
            Controls.Add(bt_go);
            Controls.Add(bt_goback);
            Name = "Bai3";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_goback;
        private Button bt_go;
        private Button bt_download;
        private Panel pn_display;
        private TextBox tb_url;
        private Button bt_view_resource;
    }
}