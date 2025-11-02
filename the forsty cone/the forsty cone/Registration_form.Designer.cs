using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace the_forsty_cone
{
    partial class Registration_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_form));
            tbox_password = new TextBox();
            tbox_email = new TextBox();
            tbox_confirmpassword = new TextBox();
            tbox_username = new TextBox();
            button1 = new Button();
            tbox_DOB = new TextBox();
            pictureBox1 = new PictureBox();
            btn_register = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbox_password
            // 
            tbox_password.BackColor = Color.Gainsboro;
            tbox_password.BorderStyle = BorderStyle.None;
            tbox_password.Location = new Point(45, 190);
            tbox_password.Name = "tbox_password";
            tbox_password.PasswordChar = '*';
            tbox_password.PlaceholderText = "Password";
            tbox_password.Size = new Size(224, 16);
            tbox_password.TabIndex = 2;
            // 
            // tbox_email
            // 
            tbox_email.BackColor = Color.Gainsboro;
            tbox_email.BorderStyle = BorderStyle.None;
            tbox_email.Location = new Point(45, 293);
            tbox_email.Name = "tbox_email";
            tbox_email.PlaceholderText = "Email";
            tbox_email.Size = new Size(219, 16);
            tbox_email.TabIndex = 6;
            // 
            // tbox_confirmpassword
            // 
            tbox_confirmpassword.BackColor = Color.Gainsboro;
            tbox_confirmpassword.BorderStyle = BorderStyle.None;
            tbox_confirmpassword.Location = new Point(45, 241);
            tbox_confirmpassword.Name = "tbox_confirmpassword";
            tbox_confirmpassword.PasswordChar = '*';
            tbox_confirmpassword.PlaceholderText = "Confirm Password";
            tbox_confirmpassword.Size = new Size(222, 16);
            tbox_confirmpassword.TabIndex = 7;
            tbox_confirmpassword.TextChanged += tbox_confirmpassword_TextChanged;
            // 
            // tbox_username
            // 
            tbox_username.BackColor = Color.Gainsboro;
            tbox_username.BorderStyle = BorderStyle.None;
            tbox_username.Location = new Point(44, 140);
            tbox_username.Name = "tbox_username";
            tbox_username.PlaceholderText = "Username";
            tbox_username.Size = new Size(220, 16);
            tbox_username.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(62, 472);
            button1.Name = "button1";
            button1.Size = new Size(174, 23);
            button1.TabIndex = 10;
            button1.Text = "Go to Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbox_DOB
            // 
            tbox_DOB.BackColor = Color.Gainsboro;
            tbox_DOB.BorderStyle = BorderStyle.None;
            tbox_DOB.Location = new Point(45, 347);
            tbox_DOB.Name = "tbox_DOB";
            tbox_DOB.PlaceholderText = "Date of Birth";
            tbox_DOB.Size = new Size(218, 16);
            tbox_DOB.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 490);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Black;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.ForeColor = SystemColors.ButtonHighlight;
            btn_register.Location = new Point(41, 421);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(231, 30);
            btn_register.TabIndex = 0;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // Registration_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 667);
            Controls.Add(tbox_DOB);
            Controls.Add(button1);
            Controls.Add(tbox_confirmpassword);
            Controls.Add(tbox_email);
            Controls.Add(tbox_password);
            Controls.Add(tbox_username);
            Controls.Add(btn_register);
            Controls.Add(pictureBox1);
            Name = "Registration_form";
            Text = "Registration_form";
            Load += Registration_form_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbox_password;
        private TextBox tbox_email;
        private TextBox tbox_confirmpassword;
        private TextBox tbox_username;
        private Button button1;
        private TextBox tbox_DOB;
        private PictureBox pictureBox1;
        private Button btn_register;
    }
}




 
