﻿


using Google.Protobuf.WellKnownTypes;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

//using MySql.Data.MySqlClient;
//sql client import



namespace the_forsty_cone
{
    public partial class Registration_form : Form
    {
        Login login = new Login();

        Users u1 = new Users();





        public Registration_form()
        {

            InitializeComponent();
        }





        private void btn_register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbox_username.Text) == true && string.IsNullOrWhiteSpace(tbox_password.Text) &&
                string.IsNullOrWhiteSpace(tbox_confirmpassword.Text) && string.IsNullOrWhiteSpace(tbox_email.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check if any fields are empty
            if (tbox_password.Text != tbox_confirmpassword.Text)
            {

                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check if passwords match
            if (tbox_email.Text.Contains("@") == false || tbox_email.Text.Contains(".") == false)
            {
                MessageBox.Show("Email requires @ and .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            u1.username = tbox_username.Text;
            u1.password = tbox_password.Text;
            u1.email = tbox_email.Text;
            u1.DOB = tbox_DOB.Text;

            Database db1 = new Database();
            db1.addnewuser(u1);
        }

        //      }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }

        private void Registration_form_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void tbox_confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_confirmPassword_Click(object sender, EventArgs e)
        {

        }
    }

}
