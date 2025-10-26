﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace the_forsty_cone
{
    public partial class Newpwd : Form
    {
        private string email_user_class;

        public Newpwd()
        {
            InitializeComponent();
        }

        public Newpwd(string email_user_input)
        {
            email_user_class = email_user_input;
            InitializeComponent();

        }

        private void Newpwd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Database d1 = new Database();

            if (d1.UpdatePassword(email_user_class,tbx_password.Text) == true)
            {
                MessageBox.Show("Password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               MessageBox.Show("Error updating password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            this.Close();
        }
    }
}
