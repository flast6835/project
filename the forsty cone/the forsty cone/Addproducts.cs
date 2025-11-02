using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace the_forsty_cone
{
    public partial class Addproducts : Form


    {


        Products p1 = new Products();   // Create an instance of the Products class to hold product details
        Database db = new Database();// Create an instance of the Database class to handle database operations
        public Addproducts()
        {
            InitializeComponent();


        }
        public void SetEditMode(int productID, string productName, int productPrice) //this method sets the form in edit mode with existing product details
        { // Method to set the form in edit mode with existing product details
            tbx_productname.Text = p1.ProductName;
            tbx_productprice.Text = p1.ProductPrice.ToString();
            productID = p1.ProductId; // Store the product ID for later use
        }
        private void Addproducts_Load(object sender, EventArgs e)
        {

        }

        private void btn_adddata_Click(object sender, EventArgs e) //this method checks the input and adds the product to the database
        {


            if (!int.TryParse(tbx_productprice.Text, out int price)) // Validate that the price is a valid integer
            {
                MessageBox.Show("Please enter a valid numeric price.");
                return;
            }
            // Set product details from the input fields
            p1.ProductName = tbx_productname.Text;
            p1.ProductPrice = price;
            p1.imageurl = tbx_productimage.Text;

            db.addproducts(p1); // Call the method to add the product to the database


        }

        private void tbx_productname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Session.Instance.Clear();
            this.Hide();

            Login m1 = new Login();
            m1.ShowDialog();
        }
    }
}
