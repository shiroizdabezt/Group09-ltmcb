namespace Lab4
{
    partial class Bai6Show
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
            pnInf=new Panel();
            SuspendLayout();
            // 
            // pnInf
            // 
            pnInf.Location=new Point(12, 12);
            pnInf.Name="pnInf";
            pnInf.Size=new Size(859, 505);
            pnInf.TabIndex=0;
            // 
            // Bai6Show
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(883, 529);
            Controls.Add(pnInf);
            Name="Bai6Show";
            Text="Bai6Show";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnInf;
    }
}