namespace the_forsty_cone
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            tbx_username = new TextBox();
            tbx_dob = new TextBox();
            button1 = new Button();
            tbx_email = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbx_username
            // 
            tbx_username.BackColor = Color.Gainsboro;
            tbx_username.BorderStyle = BorderStyle.None;
            tbx_username.Location = new Point(31, 194);
            tbx_username.Name = "tbx_username";
            tbx_username.PlaceholderText = "Username";
            tbx_username.Size = new Size(317, 16);
            tbx_username.TabIndex = 3;
            tbx_username.TextChanged += tbx_username_TextChanged;
            // 
            // tbx_dob
            // 
            tbx_dob.BackColor = Color.Gainsboro;
            tbx_dob.BorderStyle = BorderStyle.None;
            tbx_dob.Location = new Point(31, 337);
            tbx_dob.Name = "tbx_dob";
            tbx_dob.PlaceholderText = "Date Of Birth";
            tbx_dob.Size = new Size(317, 16);
            tbx_dob.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(31, 412);
            button1.Name = "button1";
            button1.Size = new Size(317, 44);
            button1.TabIndex = 5;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbx_email
            // 
            tbx_email.BackColor = Color.Gainsboro;
            tbx_email.BorderStyle = BorderStyle.None;
            tbx_email.Location = new Point(31, 266);
            tbx_email.Name = "tbx_email";
            tbx_email.PlaceholderText = "Email";
            tbx_email.Size = new Size(317, 16);
            tbx_email.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 730);
            Controls.Add(tbx_email);
            Controls.Add(button1);
            Controls.Add(tbx_dob);
            Controls.Add(tbx_username);
            Controls.Add(pictureBox1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbx_username;
        private TextBox tbx_dob;
        private Button button1;
        private TextBox tbx_email;
        private PictureBox pictureBox1;
    }
}