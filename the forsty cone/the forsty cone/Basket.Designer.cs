namespace the_forsty_cone
{
    partial class Basket
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
            btn_pay = new Button();
            btn_remove = new Button();
            btn_close = new Button();
            SuspendLayout();
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(328, 314);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(126, 56);
            btn_pay.TabIndex = 0;
            btn_pay.Text = "Pay";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(57, 314);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(126, 56);
            btn_remove.TabIndex = 1;
            btn_remove.Text = "Remove item";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(413, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(89, 59);
            btn_close.TabIndex = 6;
            btn_close.Text = "Logout";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 730);
            Controls.Add(btn_close);
            Controls.Add(btn_remove);
            Controls.Add(btn_pay);
            Name = "Basket";
            Text = "Basket";
            Load += Basket_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_pay;
        private Button btn_remove;
        private Button btn_close;
    }
}