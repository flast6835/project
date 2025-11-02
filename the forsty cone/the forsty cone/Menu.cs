
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

//namespace the_forsty_cone
//{
//    public partial class Menu : Form
//    {


//        ListView listView;
//        ImageList imageList;
//        public Menu()
//        {
//            InitializeComponent();


//        }

//        private void Menu_Load(object sender, EventArgs e)
//        {
//            loadproducts();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }




//        //private void loadproducts()
//        //{
//        //    listView1.Items.Clear();

//        //    // Setup ImageList for displaying images
//        //    imageList = new ImageList();
//        //    imageList.ImageSize = new Size(64, 64); // Set the desired image size
//        //    listView1.LargeImageList = imageList; // For LargeIcon view
//        //    listView1.SmallImageList = imageList; // For Details view

//        //    // Set ListView properties
//        //    listView1.View = View.Details;
//        //    listView1.FullRowSelect = true;
//        //    listView1.GridLines = true;

//        //    // Define columns
//        //    listView1.Columns.Clear();
//        //    listView1.Columns.Add("Product ID", 100);
//        //    listView1.Columns.Add("Product Name", 150);
//        //    listView1.Columns.Add("Product Price", 100);
//        //    listView1.Columns.Add("Image", 200); // This will show the image, not URL

//        //    Database db = new Database();
//        //    List<Products> products = db.getallProducts();

//        //    int imageIndex = 0;

//        //    foreach (Products product in products)
//        //    {
//        //        try
//        //        {
//        //            // Load image from the URL/path
//        //            Image productImage = Image.FromFile(product.imageurl);
//        //            imageList.Images.Add(productImage);

//        //            // Create ListViewItem with image
//        //            ListViewItem item = new ListViewItem(product.ProductId.ToString(), imageIndex);
//        //            item.SubItems.Add(product.ProductName);
//        //            item.SubItems.Add(product.ProductPrice.ToString());
//        //            item.SubItems.Add(""); // Empty text for image column, image will show in first column

//        //            listView1.Items.Add(item);
//        //            imageIndex++;
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            // If image fails to load, use a default image or continue without image
//        //            Console.WriteLine($"Error loading image for {product.ProductName}: {ex.Message}");

//        //            // Add item without image
//        //            ListViewItem item = new ListViewItem(product.ProductId.ToString());
//        //            item.SubItems.Add(product.ProductName);
//        //            item.SubItems.Add(product.ProductPrice.ToString());
//        //            item.SubItems.Add("Image not available");

//        //            listView1.Items.Add(item);
//        //        }
//        //    }
//        //}

//        //private void loadproducts()
//        //{
//        //    listView1.Items.Clear();
//        //    imageList = new ImageList();
//        //    imageList.ImageSize = new Size(64, 64); // Set the desired image
//        //    {

//        //        //     imageList.Images.Add("apple", Image.FromFile("C:/Users/flast/OneDrive/Pictures/Screenshots/Screenshot 2025-10-03 142227.png"));// Set the size of the images

//        //        listView1.LargeImageList = imageList;

//        //        // 3️⃣ Set the ListView display mode
//        //        listView1.View = View.LargeIcon;
//        //        listView1.Items.Add(new ListViewItem("Apple", 0));
//        //    }
//        //    ;






//        //    Database db = new Database();
//        //    List<Products> products = db.getallProducts();
//        //    listView1.View = View.Details;
//        //    listView1.FullRowSelect = true;


//        //    listView1.Columns.Clear();

//        //    listView1.Columns.Add("Product ID", 100);
//        //    listView1.Columns.Add("Product Name", 150);
//        //    listView1.Columns.Add("Product Price", 100);
//        //    listView1.Columns.Add("Image URL", 200);

//        //    listView1.Items.Clear();

//        //    foreach (Products product in products)
//        //    {
//        //        ListViewItem item = new ListViewItem(product.ProductId.ToString());

//        //        item.SubItems.Add(product.ProductName);
//        //        item.SubItems.Add(product.ProductPrice.ToString());
//        //        item.SubItems.Add(product.imageurl);

//        //        listView1.Items.Add(item);
//        //    }
//        //}




//        private void loadproducts()
//        {
//            listView1.Items.Clear();

//            // Setup ImageList
//            imageList = new ImageList();
//            imageList.ImageSize = new Size(64, 64);
//            listView1.SmallImageList = imageList;
//            listView1.LargeImageList = imageList;

//            listView1.View = View.Details;
//            listView1.FullRowSelect = true;

//            // Define columns
//            listView1.Columns.Clear();
//            listView1.Columns.Add("Image", 80);
//            listView1.Columns.Add("Product ID", 100);
//            listView1.Columns.Add("Product Name", 150);
//            listView1.Columns.Add("Product Price", 100);


//            Database db = new Database();
//            List<Products> products = db.getallProducts();

//            int imageIndex = 0;

//            foreach (Products product in products)
//            {
//                try
//                {
//                    // Clean the path - remove quotes and trim
//                    string cleanPath = CleanImagePath(product.imageurl);

//                    Console.WriteLine($"Trying to load: {cleanPath}");
//                    Console.WriteLine($"File exists: {File.Exists(cleanPath)}");

//                    if (File.Exists(cleanPath))
//                    {
//                        Image productImage = LoadImage(cleanPath);
//                        if (productImage != null)
//                        {
//                            imageList.Images.Add(productImage);

//                            ListViewItem item = new ListViewItem("", imageIndex);
//                            item.SubItems.Add(product.ProductId.ToString());
//                            item.SubItems.Add(product.ProductName);
//                            item.SubItems.Add(product.ProductPrice.ToString("C"));



//                            listView1.Items.Add(item);

//                            imageIndex++;
//                            Console.WriteLine($"Successfully loaded image for {product.ProductName}");
//                        }
//                        else
//                        {
//                            AddItemWithoutImage(product, "Invalid image");
//                        }
//                    }
//                    else
//                    {
//                        AddItemWithoutImage(product, "File not found");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    AddItemWithoutImage(product, $"Error: {ex.Message}");
//                    Console.WriteLine($"Error: {ex.Message}");
//                }
//            }
//        }

//        private string CleanImagePath(string path)
//        {
//            if (string.IsNullOrEmpty(path)) return path;

//            // Remove quotes and trim
//            string cleanPath = path.Replace("\"", "").Trim();

//            // Fix path separators if needed
//            cleanPath = cleanPath.Replace('/', '\\');

//            return cleanPath;
//        }

//        private Image LoadImage(string filePath)
//        {
//            try
//            {
//                // For .webp files, we might need special handling
//                string extension = Path.GetExtension(filePath).ToLower();

//                if (extension == ".webp")
//                {
//                    // Try using Image.FromFile first
//                    try
//                    {
//                        return Image.FromFile(filePath);
//                    }
//                    catch
//                    {
//                        // If .webp fails, try to convert or use a fallback
//                        return HandleWebPImage(filePath);
//                    }
//                }
//                else
//                {
//                    // For other image formats
//                    return Image.FromFile(filePath);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error loading image {filePath}: {ex.Message}");
//                return null;
//            }
//        }

//        private Image HandleWebPImage(string filePath)
//        {
//            // Option 1: Use a placeholder image for .webp files
//            try
//            {
//                // Create a simple placeholder bitmap
//                Bitmap placeholder = new Bitmap(64, 64);
//                using (Graphics g = Graphics.FromImage(placeholder))
//                {
//                    g.Clear(Color.LightGray);
//                    using (Font font = new Font("Arial", 8))
//                    {
//                        g.DrawString("WEBP", font, Brushes.Black, new PointF(5, 25));
//                    }
//                }
//                return placeholder;
//            }
//            catch
//            {
//                return null;
//            }
//        }

//        private void AddItemWithoutImage(Products product, string status)
//        {
//            ListViewItem item = new ListViewItem(status);
//            item.SubItems.Add(product.ProductId.ToString());
//            item.SubItems.Add(product.ProductName);
//            item.SubItems.Add(product.ProductPrice.ToString("C"));
//            listView1.Items.Add(item);
//            Console.WriteLine($"Added without image: {product.ProductName} - {status}");
//        }




//        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        {


//            if (listView1.SelectedItems.Count > 0)
//            {


//                string name = "";
//                string imgurl = "";
//                ListViewItem selectedItem = listView1.SelectedItems[0];
//                string id = selectedItem.SubItems[0].Text; // Product ID
//                name = selectedItem.SubItems[1].Text; // Product Name
//                string price = selectedItem.SubItems[2].Text; // Product Price
//                imgurl = selectedItem.SubItems[3].Text; // Image URL


//                //Products p1 = new Products
//                //{
//                //    ProductId = int.Parse(id),
//                //    ProductName = name,
//                //    ProductPrice = int.Parse(price),
//                //    imageurl = "rnadom"
//                //};

//                //box.Add(p1);


//            }
//        }


//        List<Products> box = new List<Products>();
//        private void btnAddToCart_Click(object sender, EventArgs e)

//        {
//            if (listView1.SelectedItems.Count == 0)
//            {
//                MessageBox.Show("Please select a product first!");
//                return;
//            }

//            ListViewItem selectedItem = listView1.SelectedItems[0];

//      
//            string name = selectedItem.SubItems[2].Text;
//            string priceText = selectedItem.SubItems[3].Text.Replace("£", "").Trim();

//            if (!decimal.TryParse(priceText, out decimal price))
//            {
//                MessageBox.Show("Invalid price format.");
//                return;
//            }

//          
//            Products p = new Products { ProductName = name, ProductPrice = (int)price };
//            box.Add(p);


//        }



//        private void btnRemoveFromCart_Click(object sender, EventArgs e)
//        {
//            if (listView1.SelectedItems.Count == 0)
//            {
//                MessageBox.Show("Select an item in the cart to remove.");
//                return;
//            }

//            int index = listView1.SelectedItems[0].Index;
//            box.RemoveAt(index);


//        }


//        private void button1_Click_1(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void btn_add_Click(object sender, EventArgs e)
//        {
//            btnAddToCart_Click(sender, e);
//        }
//    }
//}






using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;

namespace the_forsty_cone
{
    public partial class Menu : Form
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Clear session on form close
                //Session.Instance.Clear();
            }
        }

        private ListView listView;
        private ImageList imageList;
        private ContextMenuStrip contextMenu;
        private Database db;
        private Button btnLogout;
        private Label lblWelcome;

        public Menu()
        {
            InitializeComponent();


            // Check if session is valid
            if (Session.Instance.UserId == 0 || string.IsNullOrEmpty(Session.Instance.Username))
            {
                MessageBox.Show("Invalid session. Please log in again.", "Session Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            db = new Database();
            SetupUI();
            SetupContextMenu();
        }

        bool chkAdmin()
        {
            if (Session.Instance.IsAdmin == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetupUI()
        {

            // Add welcome label
            lblWelcome = new Label();


            lblWelcome.Text = $"Welcome {Session.Instance.Username} ({(chkAdmin() ? "Admin" : "User")})";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(10, 10);
            this.Controls.Add(lblWelcome);

            // Add logout button
            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Location = new Point(this.ClientSize.Width - 100, 10);
            btnLogout.Click += BtnLogout_Click;
            this.Controls.Add(btnLogout);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.Instance.Clear();
                this.Close();
            }
        }

        private void SetupContextMenu()
        {
            contextMenu = new ContextMenuStrip();

            if (Session.Instance.IsAdmin == 1)
            {
                contextMenu.Items.Add("Edit Product", null, EditProduct_Click);
                contextMenu.Items.Add("Delete Product", null, DeleteProduct_Click);
            }
            else
            {
                contextMenu.Items.Add("Add to Basket", null, AddToBasket_Click);
                contextMenu.Items.Add("Remove from Basket", null, RemoveFromBasket_Click);
            }

            listView1.ContextMenuStrip = contextMenu;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            loadproducts();
        }

        private void EditProduct_Click(object sender, EventArgs e) //this is for admin to edit products
        {
            if (listView1.SelectedItems.Count > 0) // Check if an item is selected
            {
                ListViewItem selected = listView1.SelectedItems[0]; // Get the selected item
                int productId = int.Parse(selected.SubItems[0].Text);
                string productName = selected.SubItems[1].Text;
                int productPrice = int.Parse(selected.SubItems[2].Text);

                // Open edit form
                var addProductForm = new Addproducts(); // Create instance of Addproducts form
                addProductForm.SetEditMode(productId, productName, productPrice); // Set form to edit mode
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    loadproducts(); // Refresh the list
                }
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e) //this is for admin to delete products
        {
            if (listView1.SelectedItems.Count > 0) // Check if an item is selected
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListViewItem selected = listView1.SelectedItems[0]; // Get the selected item
                    int productId = int.Parse(selected.SubItems[0].Text); // Get Product ID
                    db.deleteproducts(productId); // Delete product from database
                    loadproducts(); // Refresh the list
                }
            }
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView1.SelectedItems[0];
                int productId = int.Parse(selected.SubItems[0].Text);
                string productName = selected.SubItems[1].Text;
                int productPrice = int.Parse(selected.SubItems[2].Text);

                // Add to basket (you'll need to implement this in your Database class)
                db.AddToBasket(Session.Instance.UserId, productId);
                MessageBox.Show($"{productName} has been added to your basket!", "Success");
            }
        }

        private void RemoveFromBasket_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView1.SelectedItems[0];
                int productId = int.Parse(selected.SubItems[0].Text);
                string productName = selected.SubItems[1].Text;

                // Remove from basket 
                db.RemoveFromBasket(Session.Instance.UserId, productId);
                MessageBox.Show($"{productName} has been removed from your basket!", "Success");
            }
        }






        private void loadproducts()
        {
            listView1.Items.Clear();

            // Setup ImageList
            imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            listView1.SmallImageList = imageList;
            listView1.LargeImageList = imageList;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Define columns
            listView1.Columns.Clear();
            listView1.Columns.Add("Image", 80);
            listView1.Columns.Add("Product ID", 100);
            listView1.Columns.Add("Product Name", 150);
            listView1.Columns.Add("Product Price", 100);


            Database db = new Database();
            List<Products> products = db.getallProducts();

            int imageIndex = 0; // Index for images in ImageList

            foreach (Products product in products) // Iterate through each product
            {
                try
                {
                    // Clean the path - remove quotes and trim
                    string cleanPath = CleanImagePath(product.imageurl); // Clean the image path to make it usable
                                                                         //      MessageBox.Show($"Trying to load: {cleanPath}"); //debugging
                                                                         //    MessageBox.Show($"File exists: {File.Exists(cleanPath)}"); //check if file exists


                    if (File.Exists(cleanPath)) // Check if file exists
                    {
                        Image productImage = LoadImage(cleanPath); // Load the image
                        if (productImage != null)// If image loaded successfully
                        {
                            imageList.Images.Add(productImage); // Add image to ImageList

                            ListViewItem item = new ListViewItem("", imageIndex); // Create ListViewItem with image
                            //add subitems
                            item.SubItems.Add(product.ProductId.ToString());
                            item.SubItems.Add(product.ProductName);
                            item.SubItems.Add(product.ProductPrice.ToString("C"));



                            listView1.Items.Add(item);

                            imageIndex++; // Increment image index
                                          //      MessageBox.Show($"Successfully loaded image for {product.ProductName}"); 

                        }
                        else
                        {
                            AddItemWithoutImage(product, "Invalid image");
                        }
                    }
                    else
                    {
                        AddItemWithoutImage(product, "File not found");
                    }
                }
                catch (Exception ex)
                {
                    AddItemWithoutImage(product, $"Error: {ex.Message}");
                    //  MessageBox.Show($"Error: {ex.Message}");

                }
            }
        }

        private string CleanImagePath(string path) // Clean the image path to make it usable
        {
            if (string.IsNullOrEmpty(path)) // Check for null or empty

                return path; // Return as it is

            // If not null or empty

            // Remove quotes and trim it
            string cleanPath = path.Replace("\"", "").Trim();

            // Fix path separators if needed
            cleanPath = cleanPath.Replace('/', '\\');

            return cleanPath; // Return cleaned path

        }

        private Image LoadImage(string filePath) // Load image from file
        {
            try
            {
                // For .webp files, we might need special handling
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".webp") // If file is .webp
                {
                    // Try using Image.FromFile first
                    try
                    {
                        return Image.FromFile(filePath);
                    }
                    catch
                    {
                        // If .webp fails, try to convert or use a fallback
                        return HandleWebPImage(filePath);
                    }
                }
                else
                {
                    // For other image formats
                    return Image.FromFile(filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image {filePath}: {ex.Message}");
                return null; // Return null if error occurs
            }
        }

        private Image HandleWebPImage(string filePath) // Handle .webp images
        {
            // Use a placeholder image for .webp files
            try
            {
                // Create a simple placeholder bitmap
                Bitmap placeholder = new Bitmap(64, 64);
                using (Graphics g = Graphics.FromImage(placeholder))
                {
                    g.Clear(Color.LightGray);
                    using (Font font = new Font("Arial", 8))
                    {
                        g.DrawString("WEBP", font, Brushes.Black, new PointF(5, 25));
                    }
                }
                return placeholder;
            }
            catch
            {
                return null;
            }
        }


        private void AddItemWithoutImage(Products product, string status) // Add item without image
        {
            ListViewItem item = new ListViewItem(status); // Create ListViewItem with status
            item.SubItems.Add(product.ProductId.ToString());
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductPrice.ToString("C"));
            listView1.Items.Add(item);
            Console.WriteLine($"Added without image: {product.ProductName} - {status}");
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0) //this checks if any item is selected
            {


                string name = "";
                string imgurl = "";
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text; // Product ID
                name = selectedItem.SubItems[1].Text; // Product Name
                string price = selectedItem.SubItems[2].Text; // Product Price
                imgurl = selectedItem.SubItems[3].Text; // Image URL




            }
        }


        List<Products> box = new List<Products>();

        private Basket b1;




        private void btnAddToCart_Click(object sender, EventArgs e)

        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product first!");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];


            string name = selectedItem.SubItems[2].Text;
            string priceText = selectedItem.SubItems[3].Text.Replace("£", "").Trim();

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }


            Products p = new Products { ProductName = name, ProductPrice = (int)price };
            box.Add(p);



            //reload manually if we already have an instace open, if we have no instace open we open another.
            //if (b1 == null) { 
            //Basket b1 = new Basket(box);
            //    b1.Show();
            //}
            //else
            //{
            //    b1.updatebasket(box);
            //}


            if (b1 != null && !b1.IsDisposed)
            {
                b1.Close();
            }

            // Open a new basket
            b1 = new Basket(box);
            b1.Show();
        }



        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item in the cart to remove.");
                return;
            }

            int index = listView1.SelectedItems[0].Index;
            box.RemoveAt(index);


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btnAddToCart_Click(sender, e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            RemoveFromBasket_Click(sender, e);
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
