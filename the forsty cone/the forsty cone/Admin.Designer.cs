namespace the_forsty_cone
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            btn_remove = new Button();
            btn_seeuserlist = new Button();
            btn_viewmenu = new Button();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaptionText;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(71, 302);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(259, 33);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add Product To Menu";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = SystemColors.ActiveCaptionText;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.ForeColor = SystemColors.ButtonHighlight;
            btn_remove.Location = new Point(71, 363);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(259, 33);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remove Products From Menu";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_seeuserlist
            // 
            btn_seeuserlist.BackColor = SystemColors.ActiveCaptionText;
            btn_seeuserlist.FlatAppearance.BorderSize = 0;
            btn_seeuserlist.FlatStyle = FlatStyle.Flat;
            btn_seeuserlist.ForeColor = SystemColors.ButtonHighlight;
            btn_seeuserlist.Location = new Point(69, 425);
            btn_seeuserlist.Name = "btn_seeuserlist";
            btn_seeuserlist.Size = new Size(259, 33);
            btn_seeuserlist.TabIndex = 3;
            btn_seeuserlist.Text = "See all users";
            btn_seeuserlist.UseVisualStyleBackColor = false;
            btn_seeuserlist.Click += btn_seeuserlist_Click;
            // 
            // btn_viewmenu
            // 
            btn_viewmenu.Location = new Point(71, 479);
            btn_viewmenu.Name = "btn_viewmenu";
            btn_viewmenu.Size = new Size(257, 47);
            btn_viewmenu.TabIndex = 4;
            btn_viewmenu.Text = "view menu";
            btn_viewmenu.UseVisualStyleBackColor = true;
            btn_viewmenu.Click += btn_viewmenu_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(267, 33);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(61, 48);
            btn_close.TabIndex = 5;
            btn_close.Text = "Logout";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 593);
            Controls.Add(btn_close);
            Controls.Add(btn_viewmenu);
            Controls.Add(btn_seeuserlist);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_seeuserlist;
        private Button btn_viewmenu;
        private Button btn_close;
    }
}