namespace the_forsty_cone
{
    partial class Newpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newpwd));
            tbx_password = new TextBox();
            tbx_confirmpassword = new TextBox();
            btn_reset = new Button();
            btn_back = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbx_password
            // 
            tbx_password.BackColor = Color.Gainsboro;
            tbx_password.BorderStyle = BorderStyle.None;
            tbx_password.Location = new Point(52, 317);
            tbx_password.Name = "tbx_password";
            tbx_password.PlaceholderText = "Enter New Password";
            tbx_password.Size = new Size(314, 16);
            tbx_password.TabIndex = 0;
            tbx_password.TextChanged += textBox1_TextChanged;
            // 
            // tbx_confirmpassword
            // 
            tbx_confirmpassword.BackColor = Color.Gainsboro;
            tbx_confirmpassword.BorderStyle = BorderStyle.None;
            tbx_confirmpassword.Location = new Point(53, 387);
            tbx_confirmpassword.Name = "tbx_confirmpassword";
            tbx_confirmpassword.PlaceholderText = "Confirm Password";
            tbx_confirmpassword.Size = new Size(315, 16);
            tbx_confirmpassword.TabIndex = 1;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.Black;
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI", 12F);
            btn_reset.ForeColor = SystemColors.ControlLightLight;
            btn_reset.Location = new Point(53, 465);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(315, 44);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gainsboro;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 8F);
            btn_back.Location = new Point(302, 94);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(69, 52);
            btn_back.TabIndex = 6;
            btn_back.Text = "back to frontpage";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Newpwd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 687);
            Controls.Add(btn_back);
            Controls.Add(btn_reset);
            Controls.Add(tbx_confirmpassword);
            Controls.Add(tbx_password);
            Controls.Add(pictureBox1);
            Name = "Newpwd";
            Text = "Newpwd";
            Load += Newpwd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_password;
        private TextBox tbx_confirmpassword;
        private Button btn_reset;
        private Button btn_back;
        private PictureBox pictureBox1;
    }
}