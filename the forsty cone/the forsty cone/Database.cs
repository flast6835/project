
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace the_forsty_cone
{




    internal class Database
    {
        string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

        public void addnewuser(Users user)
        {
            // Hash the password before storing
            string hashedPassword = PasswordHasher.HashPassword(user.password);

            string insertQuery = "INSERT INTO users (username, email, [password],DOB,isadmin) VALUES (@username, @email, @password ,@dob,@admin)";

            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try //checks for errors
                {
                    con.Open();
                    //adds into database with hashed password
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@password", hashedPassword); // Store hashed password
                        cmd.Parameters.AddWithValue("@dob", user.DOB);
                        cmd.Parameters.AddWithValue("@admin", user.isAdmin);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Register successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) //checks for errors
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }


        public void deleteuser(int id_user)
        {

            string delquery = "DELETE FROM users where id = @id";

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(delquery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id_user);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                con.Close();
            }
        }




        public void addproducts(Products product2) //this method adds a new product to the database
        {

            string insertQuery = "INSERT INTO Products (Product_name, Product_price, Product_image) VALUES (@name, @price,@img)"; // SQL query to insert a new product

            using (SqlConnection con = new SqlConnection(this.stringconnction)) //creates a connection to the database
            {

                try //checks for errors
                {
                    con.Open();
                    //adds into database
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", product2.ProductName); //this line adds the product name to the SQL command
                        cmd.Parameters.AddWithValue("@price", product2.ProductPrice);
                        cmd.Parameters.AddWithValue("@img", product2.imageurl);




                        cmd.ExecuteNonQuery(); //executes the SQL command to insert the new product

                        MessageBox.Show("Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                }

                catch (Exception ex) //checks for errors
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
        }

        public bool loginuser(string username, string password) //this method handles user login
        {
            try
            {
                string query = @"SELECT id, username, isadmin, password 
                                 FROM users 
                                 WHERE UPPER(username)=UPPER(@username)"; // SQL query to select user details based on username

                using (SqlConnection con = new SqlConnection(stringconnction)) //creates a connection to the database
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con)) //creates a SQL command
                    {
                        cmd.Parameters.AddWithValue("@username", username ?? string.Empty); //adds the username parameter to the SQL command

                        using (SqlDataReader reader = cmd.ExecuteReader()) //executes the SQL command and reads the results
                        {
                            if (reader.Read()) //checks if a user record was found
                            {
                                string hashedPassword = reader.GetString(3); //retrieves the hashed password from the database
                                if (PasswordHasher.VerifyPassword(password, hashedPassword)) //verifies the provided password against the hashed password
                                {
                                    // If password is correct, set session details
                                    Session.Instance.UserId = reader.GetInt32(0);
                                    Session.Instance.Username = reader.GetString(1);
                                    Session.Instance.IsAdmin = reader.GetInt32(2);

                                    MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return true;
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<Products> getallProducts() //this method retrieves all products from the database
        {
            string query3 = "SELECT Product_id, Product_name, product_price, Product_image FROM Products"; //SQL query to select product details

            List<Products> products_list = new List<Products>(); //list to store the retrieved products

            using (SqlConnection con = new SqlConnection(stringconnction)) //creates a connection to the database
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query3, con)) //creates a SQL command
                using (SqlDataReader reader = cmd.ExecuteReader()) //executes the SQL command and reads the results
                {
                    //iterates through each product record
                    while (reader.Read())
                    {
                        int id1 = reader.IsDBNull(0) ? 0 : reader.GetInt32(0); // Handle ID safely
                        string name1 = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);// Handle name safely

                        // Handle price safely (assuming INT in DB)
                        int price1 = 0;
                        if (!reader.IsDBNull(2))
                        {
                            // if it's int in DB
                            price1 = reader.GetInt32(2);

                        }



                        // Handle image safely
                        string image1 = reader.IsDBNull(3) ? string.Empty : reader["Product_image"].ToString();

                        // Create Product
                        Products p1 = new Products(id1, name1, price1, image1);
                        products_list.Add(p1);
                    }
                }
            }

            return products_list;
        }

        public void deleteproducts(int a)
        {

            string deleteQuery = "DELETE FROM Products WHERE Product_id = @p_id";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@p_id", a);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(" delete successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
        }


        public void RemoveFromBasket(int a, int b) // method removes a product from the user's basket
        {
            string deleteQuery = "DELETE FROM Basket WHERE Productid = @p_id and  userid= @u_id "; // SQL query to delete a product from the basket
            using (SqlConnection con = new SqlConnection(this.stringconnction)) //creates a connection to the database
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con)) //creates a SQL command
                    {
                        //adds the product ID and user ID parameters to the SQL command
                        cmd.Parameters.AddWithValue("p_id", a);
                        cmd.Parameters.AddWithValue("u_id", b);

                        cmd.ExecuteNonQuery();

                    }
                }

                catch (Exception ex) //catches any exceptions that occur during the process
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
        }

        public void AddToBasket(int a, int b) // method adds a product to the user's basket
        {
            string ADDQuery = "INSERT INTO Basket WHERE id= @u_id and Product_id = @p_id"; // SQL query to insert a product into the basket
            using (SqlConnection con = new SqlConnection(this.stringconnction)) //creates a connection to the database
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ADDQuery, con)) //creates a SQL command
                    {
                        //adds the user ID parameter to the SQL command
                        cmd.Parameters.AddWithValue("u_id", a);
                        cmd.Parameters.AddWithValue("u_id", b);

                        cmd.ExecuteNonQuery();



                    }
                }

                catch (Exception ex) //catches any exceptions that occur during the process
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
        }

        public List<(int id, string username, int isAdmin)> GetAllUsers() //method retrieves all users from the database
        {
            var users = new List<(int id, string username, int isAdmin)>(); //list to store user details
            string query = "SELECT id, username, isadmin FROM users"; // SQL query to select user details

            using (SqlConnection con = new SqlConnection(this.stringconnction)) //creates a connection to the database
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con)) //creates a SQL command
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) //executes the SQL command and reads the results
                        {
                            while (reader.Read()) //iterates through each user record

                            {
                                //adds the user details to the list
                                users.Add((
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2)
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex) //catches any exceptions that occur during the process
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return users;
        }


        bool checkEmailExist(string email) //this method checks if an email exists in the database
        {
            string query = "select count(*) from users where email=@email"; // SQL query to count records with the specified email
            int count = 0;
            using (SqlConnection con = new SqlConnection(this.stringconnction)) //creates a connection to the database
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con)) //creates a SQL command
                    {
                        cmd.Parameters.AddWithValue("@email", email); //adds the email parameter to the SQL command
                        count = (int)cmd.ExecuteScalar(); //executes the SQL command and retrieves the count of matching records
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            if (count > 0) //checks if any matching records were found
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool VerifyUserForReset(string email, string username, string dob) //this method verifies user details for password reset
        {
            if (!checkEmailExist(email)) //checks if the email exists in the database
            {
                return false; 
            }

            try
            {
                string query = @"SELECT COUNT(*)  FROM users WHERE UPPER(email)=UPPER(@email) AND UPPER(username)=UPPER(@username) AND dob=@dob"; // SQL query to count matching user records

                using (SqlConnection con = new SqlConnection(stringconnction)) //creates a connection to the database
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con)) //creates a SQL command
                    {
                        //adds parameters to the SQL command
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        int count = (int)cmd.ExecuteScalar(); //executes the SQL command and retrieves the count of matching records
                        return count > 0; //returns true if a matching record is found, otherwise false
                    }
                }
            }
            catch (Exception ex) //catches any exceptions that occur during the process
            {
                MessageBox.Show("Error verifying user: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public bool UpdatePassword(string email, string newPassword) //this method updates the user's password in the database
        {
            try
            {
                // Hash the new password
                string hashedPassword = PasswordHasher.HashPassword(newPassword);

                string updateQuery = @"UPDATE users SET [password] = @password WHERE email = @email"; // SQL query to update the password

                using (SqlConnection con = new SqlConnection(stringconnction)) //creates a connection to the database
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con)) //creates a SQL command
                    {
                        //adds parameters to the SQL command
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex) //catches any exceptions that occur during the process
            {
                MessageBox.Show("Error updating password: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //public void resetpassword(string email, string username, string dob)
        //{
        //    if (checkEmailExist(email) == true)
        //    {


        //        try
        //        {
        //            string query = @"SELECT username, dob 
        //                  FROM users 
        //                  WHERE UPPER(username)=UPPER(@username) 
        //                  AND [dob]=@dob";

        //            using (SqlConnection con = new SqlConnection(stringconnction))
        //            {
        //                con.Open();
        //                using (SqlCommand cmd = new SqlCommand(query, con))
        //                {
        //                    cmd.Parameters.AddWithValue("@username", username ?? string.Empty);
        //                    cmd.Parameters.AddWithValue("@dob", dob ?? string.Empty);

        //                    using (SqlDataReader reader = cmd.ExecuteReader())
        //                    {
        //                        if (reader.Read())
        //                        {

        //                            Session.Instance.Username = reader.GetString(1);


        //                            Newpwd n1 = new Newpwd();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Wrong information", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        }
        //                    }
        //                }
        //            }


        //        }


        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        //        }
        //    }
        //}




        public void MakeAdmin(int id, int isadmin)
        {
            string ADDQuery2 = "SELECT id, isadmin FROM users";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ADDQuery2, con))
                    {
                        cmd.Parameters.AddWithValue("u_id", id);
                        cmd.Parameters.AddWithValue("u_isadmin", isadmin);
                        cmd.Parameters.AddWithValue("@isadmin", 1);
                        cmd.ExecuteNonQuery();

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
        }

    }
}



