namespace Lab4
{
    partial class ViewResource
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
            rtb_view_resources = new RichTextBox();
            SuspendLayout();
            // 
            // rtb_view_resources
            // 
            rtb_view_resources.Location = new Point(12, 12);
            rtb_view_resources.Name = "rtb_view_resources";
            rtb_view_resources.Size = new Size(776, 426);
            rtb_view_resources.TabIndex = 1;
            rtb_view_resources.Text = "";
            // 
            // ViewResource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_view_resources);
            Name = "ViewResource";
            Text = "View Resource";
            Load += ViewResource_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_view_resources;
    }
}