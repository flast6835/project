namespace the_forsty_cone
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            btn_add = new Button();
            btn_close = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(501, 505);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(56, 546);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(133, 45);
            btn_add.TabIndex = 2;
            btn_add.Text = "add to basket";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(530, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(61, 48);
            btn_close.TabIndex = 10;
            btn_close.Text = "Logout";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 659);
            Controls.Add(btn_close);
            Controls.Add(btn_add);
            Controls.Add(listView1);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ImageList imageList1;
        private Button btn_deleteitem;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_close;
    }
}
