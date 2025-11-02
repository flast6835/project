//using BCrypt.Net;
//using Google.Protobuf.WellKnownTypes;
//    using Microsoft.Data.SqlClient;
//using Org.BouncyCastle.Bcpg;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics.Eventing.Reader;
//using System.Drawing;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

//namespace the_forsty_cone
//{
//    public partial class Login : Form

//    {

//        public Login()
//        {

//            InitializeComponent();

//        }







//        private void btn_login_Click(object sender, EventArgs e)
//        {
//            Database db = new Database();
//            string username = tb_username.Text;
//            string password = tb_password.Text;

//            // Example: get hashed password from database
//            string hashedPassword = db.GetHashedPasswordFromDatabase(username);

//            if (hashedPassword == null)
//            {
//                MessageBox.Show("User not found.");
//                return;
//            }

//            //Call the method from the other class
//            bool isValid = PasswordHasher.VerifyPassword(password, hashedPassword);

//            if (isValid)
//            {
//                MessageBox.Show("Login successful!");
//                // Navigate to next form or dashboard
//            }
//            else
//            {
//                MessageBox.Show("Invalid password.");
//            }







//            if (string.IsNullOrWhiteSpace(tb_username.Text) || string.IsNullOrWhiteSpace(tb_password.Text)) //this checks if either field is empty
//            {
//                MessageBox.Show("Please enter both username and password", "Input Required",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning); //display cause of error to user
//                return;//exit the method early
//            }

//            Database db2 = new Database(); //create database object to call method

//            PasswordHasher p1 = new PasswordHasher(); //create password hasher object to hash password



//            if (db2.loginuser(tb_username.Text, tb_password.Text) == true)
//            {
//                Menu m1 = new Menu();
//                this.Hide();

//                m1.FormClosed += (s, args) =>
//                 {
//                     Session.Instance.Clear(); // Clear session when menu is closed
//                     this.Close(); // Close login form
//                 };

//                m1.Show();
//            }
//        }



//        //string u1 = tb_username.Text;
//        //string p1 = tb_password.Text;

//        //db2.loginuser(u1, p1);


//        //if (tb_username.Text != null && tb_password.Text != null)
//        //{

//        //    string u1 = tb_username.Text;
//        //    string p1 = tb_password.Text;




//        //          int workFactor = 12; // Default is 10
//        //          string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1, workFactor);


//        //          // string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1);

//        ////          string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

//        //          string query2 = "select id from users where upper(username) = upper(@username) and password = @password";

//        //          using (SqlConnection con = new SqlConnection(stringconnction))
//        //          {
//        //              try
//        //              {
//        //                  con.Open();

//        //                  using (SqlCommand cmd = new SqlCommand(query2, con))
//        //                  {
//        //                      cmd.Parameters.AddWithValue("@username", tb_username.Text);
//        //                      cmd.Parameters.AddWithValue("@password", hashedpwd);

//        //                      cmd.ExecuteNonQuery();
//        //                      int result = 0;
//        //                      if (cmd.Parameters.Count > 0)
//        //                      {
//        //                          result = (int)cmd.ExecuteScalar();

//        //                      }

//        //                      MessageBox.Show("login successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

//        //                  }





//        //                  //check with database
//        //              }
//        //              catch (Exception ex)
//        //              {
//        //                  MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //              }












//        //          }
//        //}

//        private void Login_Load(object sender, EventArgs e)
//        {




//        }

//        private void btn_createaccount_Click(object sender, EventArgs e)
//        {
//            Registration_form m1 = new Registration_form(); //open registration form
//            m1.ShowDialog(); 
//        }

//        private void btn_back_Click(object sender, EventArgs e)
//        {
//            Frontpage m1 = new Frontpage();
//            m1.ShowDialog();

//        }

//        private void btn_forgotpassword_Click(object sender, EventArgs e)
//        {
//            ForgotPassword m1 = new ForgotPassword();
//            m1.ShowDialog();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {


//        }

//        private void lbl_password_Click(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void tb_username_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            Admin m2 = new Admin();
//            m2.ShowDialog();
//        }
//    }
//}


//##########################################################
using BCrypt.Net;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace the_forsty_cone
{
    public partial class Login : Form

    {

        public Login()
        {

            InitializeComponent();

        }





        private void btn_login_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(tb_username.Text) || string.IsNullOrWhiteSpace(tb_password.Text)) //this checks if either field is empty
            {
                MessageBox.Show("Please enter both username and password", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); //display cause of error to user
                return;//exit the method early
            }

            Database db2 = new Database(); //create database object to call method

            PasswordHasher p1 = new PasswordHasher(); //create password hasher object to hash password




            if (db2.loginuser(tb_username.Text, tb_password.Text) == true) //check if login is successful
            {
                if (Session.Instance.IsAdmin == 1) //check if user is admin and open admin form
                {
                    Admin m1 = new Admin(); 
                    this.Hide();

                    m1.FormClosed += (s, args) => //when admin form is closed
                    {
                        Session.Instance.Clear(); // Clear session when admin form is closed
                        this.Close(); // Close login form
                    };

                    m1.Show();
                }
                else //normal user opens directly to menu
                {
                    Menu m1 = new Menu();
                    this.Hide();

                    m1.FormClosed += (s, args) => //when menu form is closed
                    {
                        Session.Instance.Clear(); // Clear session when menu is closed
                        this.Close(); // Close login form
                    };

                    m1.Show();
                }
            }
        }



        //string u1 = tb_username.Text;
        //string p1 = tb_password.Text;

        //db2.loginuser(u1, p1);


        //if (tb_username.Text != null && tb_password.Text != null)
        //{

        //    string u1 = tb_username.Text;
        //    string p1 = tb_password.Text;




        //          int workFactor = 12; // Default is 10
        //          string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1, workFactor);


        //          // string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1);

        ////          string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

        //          string query2 = "select id from users where upper(username) = upper(@username) and password = @password";

        //          using (SqlConnection con = new SqlConnection(stringconnction))
        //          {
        //              try
        //              {
        //                  con.Open();

        //                  using (SqlCommand cmd = new SqlCommand(query2, con))
        //                  {
        //                      cmd.Parameters.AddWithValue("@username", tb_username.Text);
        //                      cmd.Parameters.AddWithValue("@password", hashedpwd);

        //                      cmd.ExecuteNonQuery();
        //                      int result = 0;
        //                      if (cmd.Parameters.Count > 0)
        //                      {
        //                          result = (int)cmd.ExecuteScalar();

        //                      }

        //                      MessageBox.Show("login successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                  }





        //                  //check with database
        //              }
        //              catch (Exception ex)
        //              {
        //                  MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //              }












        //          }
        //}

        private void Login_Load(object sender, EventArgs e)
        {




        }

        private void btn_createaccount_Click(object sender, EventArgs e)
        {
            Registration_form m1 = new Registration_form(); //open registration form
            m1.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frontpage m1 = new Frontpage();
            m1.ShowDialog();

        }

        private void btn_forgotpassword_Click(object sender, EventArgs e)
        {
            ForgotPassword m1 = new ForgotPassword();
            m1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin m2 = new Admin();
            m2.ShowDialog();
        }
    }
}
