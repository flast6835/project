namespace the_forsty_cone
{
    partial class Removeproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Removeproducts));
            btn_remove = new Button();
            tbx_proid = new TextBox();
            pictureBox1 = new PictureBox();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_remove
            // 
            btn_remove.BackColor = SystemColors.ActiveCaptionText;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Segoe UI", 12F);
            btn_remove.ForeColor = SystemColors.HighlightText;
            btn_remove.Location = new Point(62, 441);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(283, 38);
            btn_remove.TabIndex = 0;
            btn_remove.Text = "remove product";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // tbx_proid
            // 
            tbx_proid.BackColor = Color.Gainsboro;
            tbx_proid.BorderStyle = BorderStyle.None;
            tbx_proid.Location = new Point(61, 361);
            tbx_proid.Name = "tbx_proid";
            tbx_proid.PlaceholderText = "Enter product ID";
            tbx_proid.Size = new Size(284, 16);
            tbx_proid.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 606);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(281, 47);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(61, 48);
            btn_close.TabIndex = 10;
            btn_close.Text = "Logout";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Removeproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 726);
            Controls.Add(btn_close);
            Controls.Add(tbx_proid);
            Controls.Add(btn_remove);
            Controls.Add(pictureBox1);
            Name = "Removeproducts";
            Text = "Removeproducts";
            Load += Removeproducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_remove;
        private TextBox tbx_proid;
        private PictureBox pictureBox1;
        private Button btn_close;
    }
}