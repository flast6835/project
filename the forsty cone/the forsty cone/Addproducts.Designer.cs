namespace the_forsty_cone
{
    partial class Addproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addproducts));
            label1 = new Label();
            btn_addproduct = new Button();
            tbx_productname = new TextBox();
            tbx_productprice = new TextBox();
            label4 = new Label();
            tbx_productimage = new TextBox();
            pictureBox1 = new PictureBox();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(111, 78);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Products";
            label1.Click += label1_Click;
            // 
            // btn_addproduct
            // 
            btn_addproduct.BackColor = SystemColors.ActiveCaptionText;
            btn_addproduct.FlatAppearance.BorderSize = 0;
            btn_addproduct.FlatStyle = FlatStyle.Flat;
            btn_addproduct.ForeColor = Color.White;
            btn_addproduct.Location = new Point(65, 360);
            btn_addproduct.Name = "btn_addproduct";
            btn_addproduct.Size = new Size(230, 33);
            btn_addproduct.TabIndex = 1;
            btn_addproduct.Text = "Add product";
            btn_addproduct.UseVisualStyleBackColor = false;
            btn_addproduct.Click += btn_adddata_Click;
            // 
            // tbx_productname
            // 
            tbx_productname.BackColor = Color.Gainsboro;
            tbx_productname.BorderStyle = BorderStyle.None;
            tbx_productname.Location = new Point(64, 165);
            tbx_productname.Name = "tbx_productname";
            tbx_productname.PlaceholderText = "Name of product";
            tbx_productname.Size = new Size(230, 16);
            tbx_productname.TabIndex = 2;
            tbx_productname.TextChanged += tbx_productname_TextChanged;
            // 
            // tbx_productprice
            // 
            tbx_productprice.BackColor = Color.Gainsboro;
            tbx_productprice.BorderStyle = BorderStyle.None;
            tbx_productprice.Location = new Point(65, 216);
            tbx_productprice.Name = "tbx_productprice";
            tbx_productprice.PlaceholderText = "Price of Product";
            tbx_productprice.Size = new Size(230, 16);
            tbx_productprice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(229, 265);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 7;
            label4.Click += label4_Click;
            // 
            // tbx_productimage
            // 
            tbx_productimage.BackColor = Color.Gainsboro;
            tbx_productimage.BorderStyle = BorderStyle.None;
            tbx_productimage.Location = new Point(65, 265);
            tbx_productimage.Name = "tbx_productimage";
            tbx_productimage.PlaceholderText = "image holder";
            tbx_productimage.Size = new Size(229, 16);
            tbx_productimage.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(235, 36);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(61, 48);
            btn_close.TabIndex = 9;
            btn_close.Text = "Logout";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Addproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(873, 512);
            Controls.Add(btn_close);
            Controls.Add(label4);
            Controls.Add(tbx_productimage);
            Controls.Add(tbx_productprice);
            Controls.Add(tbx_productname);
            Controls.Add(btn_addproduct);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Addproducts";
            Text = "Addproducts";
            Load += Addproducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_addproduct;
        private TextBox tbx_productname;
        private TextBox tbx_productprice;
        private Label label4;
        private TextBox tbx_productimage;
        private PictureBox pictureBox1;
        private Button btn_close;
    }
}