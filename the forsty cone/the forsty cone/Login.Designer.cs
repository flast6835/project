namespace the_forsty_cone
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login = new Button();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_forgotpassword = new Button();
            btn_createaccount = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11F);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(67, 332);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(224, 33);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_username
            // 
            tb_username.BackColor = Color.Gainsboro;
            tb_username.BorderStyle = BorderStyle.None;
            tb_username.Location = new Point(63, 217);
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Username";
            tb_username.Size = new Size(226, 16);
            tb_username.TabIndex = 2;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.Gainsboro;
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Location = new Point(64, 268);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.PlaceholderText = "Password";
            tb_password.Size = new Size(227, 16);
            tb_password.TabIndex = 4;
            // 
            // btn_forgotpassword
            // 
            btn_forgotpassword.BackColor = SystemColors.ActiveCaptionText;
            btn_forgotpassword.BackgroundImageLayout = ImageLayout.None;
            btn_forgotpassword.FlatAppearance.BorderColor = Color.Black;
            btn_forgotpassword.FlatStyle = FlatStyle.Flat;
            btn_forgotpassword.Font = new Font("Segoe UI", 11F);
            btn_forgotpassword.ForeColor = SystemColors.ControlLightLight;
            btn_forgotpassword.Location = new Point(66, 387);
            btn_forgotpassword.Name = "btn_forgotpassword";
            btn_forgotpassword.Size = new Size(227, 30);
            btn_forgotpassword.TabIndex = 5;
            btn_forgotpassword.Text = "Forgot Password";
            btn_forgotpassword.UseVisualStyleBackColor = false;
            btn_forgotpassword.Click += btn_forgotpassword_Click;
            // 
            // btn_createaccount
            // 
            btn_createaccount.BackColor = Color.Black;
            btn_createaccount.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_createaccount.FlatStyle = FlatStyle.Flat;
            btn_createaccount.Font = new Font("Segoe UI", 11F);
            btn_createaccount.ForeColor = SystemColors.ButtonHighlight;
            btn_createaccount.Location = new Point(67, 443);
            btn_createaccount.Name = "btn_createaccount";
            btn_createaccount.Size = new Size(226, 27);
            btn_createaccount.TabIndex = 7;
            btn_createaccount.Text = "create account";
            btn_createaccount.UseVisualStyleBackColor = false;
            btn_createaccount.Click += btn_createaccount_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 505);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1014, 682);
            Controls.Add(btn_createaccount);
            Controls.Add(btn_forgotpassword);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(btn_login);
            Controls.Add(pictureBox2);
            Name = "Login";
            Text = " ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_forgotpassword;
        private Button btn_createaccount;
        private PictureBox pictureBox2;
    }
}