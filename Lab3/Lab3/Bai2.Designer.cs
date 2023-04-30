namespace Lab3
{
    partial class bai2
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
            lst_received = new ListView();
            bt_listen = new Button();
            bt_exit = new Button();
            SuspendLayout();
            // 
            // lst_received
            // 
            lst_received.Location = new Point(12, 12);
            lst_received.Name = "lst_received";
            lst_received.Size = new Size(529, 426);
            lst_received.TabIndex = 0;
            lst_received.UseCompatibleStateImageBehavior = false;
            lst_received.View = View.Tile;
            // 
            // bt_listen
            // 
            bt_listen.Location = new Point(591, 55);
            bt_listen.Name = "bt_listen";
            bt_listen.Size = new Size(155, 85);
            bt_listen.TabIndex = 1;
            bt_listen.Text = "Listen";
            bt_listen.UseVisualStyleBackColor = true;
            bt_listen.Click += bt_listen_Click;
            // 
            // bt_exit
            // 
            bt_exit.Location = new Point(591, 262);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(155, 85);
            bt_exit.TabIndex = 3;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_exit);
            Controls.Add(bt_listen);
            Controls.Add(lst_received);
            Name = "bai2";
            Text = "Bai2 ";
            ResumeLayout(false);
        }

        #endregion

        private ListView lst_received;
        private Button bt_listen;
        private Button bt_exit;
    }
}