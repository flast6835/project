using System;
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
    public partial class Userlist : Form
    {



        public Userlist()
        {


            InitializeComponent();
            //  AddToUsers();
            SetupUI();
            // MakeAdmin();

        
        }

        private void listViewusers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Userlist_Load(object sender, EventArgs e)
        {

        }

        private void SetupUI()
        {
            this.Text = "Manage Users";
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterParent;

            listViewusers = new ListView();
            listViewusers.View = View.Details;
            listViewusers.FullRowSelect = true;
            listViewusers.GridLines = true;
            listViewusers.Dock = DockStyle.Top;
            listViewusers.Height = 400;

            listViewusers.Columns.Add("ID", 100);
            listViewusers.Columns.Add("Username", 200);
            listViewusers.Columns.Add("Admin", 100);

            var deleteButton = new Button
            {
                Text = "Delete Selected User",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            deleteButton.Click += DeleteSelectedUser;

            LoadUsers();

            this.Controls.Add(listViewusers);
            this.Controls.Add(deleteButton);
        }

        private void LoadUsers()
        {
            listViewusers.Items.Clear();
            Database db = new Database();
            var users = db.GetAllUsers();

            foreach (var user in users)
            {
                var item = new ListViewItem(user.id.ToString());
                item.SubItems.Add(user.username);
                item.SubItems.Add(user.isAdmin == 1 ? "Yes" : "No");
                listViewusers.Items.Add(item);
            }
        }

        private void DeleteSelectedUser(object sender, EventArgs e) // method deletes the selected user from the list
        {
            if (listViewusers.SelectedItems.Count == 0) //check if a user is selected
            {
                MessageBox.Show("Please select a user to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewusers.SelectedItems[0]; //get the selected user
            int userId = int.Parse(selectedItem.Text); //get user ID from the selected item

            if (userId == Session.Instance.UserId) //prevent admin from deleting their own account
            {
                MessageBox.Show("You cannot delete your own account", "Operation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //confirm deletion
            var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //if confirmed, delete user
            {
                Database db = new Database(); //delete user from database
                db.deleteuser(userId); //call deleteuser method from database class
                LoadUsers(); // Refresh the list 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login m1 = new Login();
            m1.ShowDialog();
        }
    }
}
