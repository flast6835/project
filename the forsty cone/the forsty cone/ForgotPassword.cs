﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace the_forsty_cone
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();


        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database d1 = new Database();
            Users u1 = new Users();

            if (string.IsNullOrWhiteSpace(tbx_username.Text) || string.IsNullOrWhiteSpace(tbx_dob.Text) || string.IsNullOrWhiteSpace(tbx_email.Text)) //this checks if either field is empty
            {
                MessageBox.Show("Please fill all inputs", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); //display cause of error to user
                return;//exit the method early
            }

            if (u1.Checkdt(tbx_dob.Text) == false)
            {
                MessageBox.Show("Date of Birth must be in DD-MM-YYYY format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (d1.VerifyUserForReset(tbx_username.Text, tbx_dob.Text, tbx_email.Text) == false)
            {
                Newpwd n1 = new Newpwd(tbx_email.Text);
                n1.ShowDialog();

                if (n1.Visible == false)
                {
                    this.Close();
                }
            }

           

        }

        private void tbx_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
