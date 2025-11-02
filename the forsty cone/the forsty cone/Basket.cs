using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Data.SqlClient;

namespace the_forsty_cone
{
    public partial class Basket : Form
    {

        private List<Products> _basketItems;
        private ListView listViewBasket;
        private Button btnClose;
        private Label lblTotal;

        public Basket(List<Products> basketItems)
        {
            InitializeComponent();
            _basketItems = basketItems ?? new List<Products>();
            SetupUI();
            LoadBasketItems();

        }
        private void SetupUI()
        {
            this.Text = " Your Basket";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            listViewBasket = new ListView();
            listViewBasket.View = View.Details;
            listViewBasket.FullRowSelect = true;
            listViewBasket.GridLines = true;
            listViewBasket.Dock = DockStyle.Top;
            listViewBasket.Height = 300;

            listViewBasket.Columns.Add("Product Name", 200);
            listViewBasket.Columns.Add("Price", 100);

            lblTotal = new Label();
            lblTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotal.Text = "Total: $0.00";
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Height = 30;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;

            btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Height = 40;
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(btnClose);
            this.Controls.Add(lblTotal);
            this.Controls.Add(listViewBasket);
        }

        private void LoadBasketItems()
        {
            listViewBasket.Items.Clear();
            decimal total = 0;

            foreach (var product in _basketItems)
            {
                var item = new ListViewItem(product.ProductName);
                item.SubItems.Add($"{product.ProductPrice:C}");
                listViewBasket.Items.Add(item);
                total += product.ProductPrice;
            }

            lblTotal.Text = $" Total: {total:C}";
        }


        public void updatebasket(List<Products> newBasketItems)
        {
            _basketItems = newBasketItems ?? new List<Products>();
            LoadBasketItems();
        }

        private void Basket_Load(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e) //payment button
        {
            string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True"; //connection string to connect to database
            string query = "select email from users where id=@idd"; //SQL query to get email of user based on their ID
            int count = 0;
            using (SqlConnection con = new SqlConnection(stringconnction)) //create connection object
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con)) //create command object with query and connection
                    {
                        cmd.Parameters.AddWithValue("@idd", Session.Instance.UserId); //add parameter value for user ID
                        SqlDataReader reader = cmd.ExecuteReader(); //execute query and get data reader
                        //check if a record is found
                        if (reader.Read())
                        {
                            string email = reader.GetString(0);
                            MessageBox.Show("Payment successful! A confirmation email has been sent to " + email, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                //show error message if exception occurs
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_remove_Click(object sender, EventArgs e) //remove selected item from basket
        {
            if (listViewBasket.SelectedItems.Count == 0) //check if an item is selected
            {
                MessageBox.Show("Please select an item to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewBasket.SelectedItems[0]; //get the selected item
            string productName = selectedItem.Text; //get product name from selected item

            var productToRemove = _basketItems.FirstOrDefault(p => p.ProductName == productName); //find the product in the basket items list

            if (productToRemove != null) //if product is found
            {
                //remove product from database and update basket items list
                Database db = new Database();
                db.RemoveFromBasket(productToRemove.ProductId, Session.Instance.UserId);
                _basketItems.Remove(productToRemove);

                LoadBasketItems();

                MessageBox.Show($"{productName} has been removed from your basket.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selected item not found in basket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

