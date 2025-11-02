//namespace the_forsty_cone
//{
//    partial class Userlist
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            button1 = new Button();
//            listViewusers = new ListView();
//            btn_makeadmin = new Button();
//            SuspendLayout();
//            // 
//            // button1
//            // 
//            button1.Location = new Point(122, 415);
//            button1.Name = "button1";
//            button1.Size = new Size(195, 47);
//            button1.TabIndex = 2;
//            button1.Text = "btn_close";
//            button1.UseVisualStyleBackColor = true;
//            button1.Click += button1_Click_1;
//            // 
//            // listViewusers
//            // 
//            listViewusers.Location = new Point(652, 494);
//            listViewusers.Name = "listViewusers";
//            listViewusers.Size = new Size(415, 298);
//            listViewusers.TabIndex = 0;
//            listViewusers.UseCompatibleStateImageBehavior = false;
//            listViewusers.SelectedIndexChanged += listViewusers_SelectedIndexChanged;
//            // 
//            // btn_makeadmin
//            // 
//            btn_makeadmin.Location = new Point(363, 415);
//            btn_makeadmin.Name = "btn_makeadmin";
//            btn_makeadmin.Size = new Size(152, 47);
//            btn_makeadmin.TabIndex = 3;
//            btn_makeadmin.Text = "Make Admin";
//            btn_makeadmin.UseVisualStyleBackColor = true;
//            btn_makeadmin.Click += btn_makeadmin_Click;
//            // 
//            // Userlist
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(1098, 827);
//            Controls.Add(btn_makeadmin);
//            Controls.Add(button1);
//            Controls.Add(listViewusers);
//            Name = "Userlist";
//            Text = "Userlist";
//            Load += Userlist_Load;
//            ResumeLayout(false);
//        }

//        #endregion
//        private Button button1;
//        private ListView listViewusers;
//        private Button btn_makeadmin;
//    }
//}



namespace the_forsty_cone
{
    partial class Userlist
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
            button1 = new Button();
            listViewusers = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(240, 487);
            button1.Name = "button1";
            button1.Size = new Size(195, 47);
            button1.TabIndex = 2;
            button1.Text = "btn_close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listViewusers
            // 
            listViewusers.Location = new Point(633, 677);
            listViewusers.Name = "listViewusers";
            listViewusers.Size = new Size(215, 83);
            listViewusers.TabIndex = 0;
            listViewusers.UseCompatibleStateImageBehavior = false;
            listViewusers.SelectedIndexChanged += listViewusers_SelectedIndexChanged;
            // 
            // Userlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 827);
            Controls.Add(button1);
            Controls.Add(listViewusers);
            Name = "Userlist";
            Text = "Userlist";
            Load += Userlist_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listViewusers;
    }
}