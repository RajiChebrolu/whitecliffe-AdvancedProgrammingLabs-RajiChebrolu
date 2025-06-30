namespace StockManagementSystem
{
    partial class Form1
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxItemCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            listBoxDisplayStockItems = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(310, 68);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(310, 219);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(310, 168);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(100, 23);
            textBoxQuantity.TabIndex = 3;
            // 
            // textBoxItemCode
            // 
            textBoxItemCode.Location = new Point(310, 116);
            textBoxItemCode.Name = "textBoxItemCode";
            textBoxItemCode.Size = new Size(100, 23);
            textBoxItemCode.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 68);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 111);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 6;
            label2.Text = "Item Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 163);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, 214);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(132, 258);
            button1.Name = "button1";
            button1.Size = new Size(132, 36);
            button1.TabIndex = 9;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxDisplayStockItems
            // 
            listBoxDisplayStockItems.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxDisplayStockItems.FormattingEnabled = true;
            listBoxDisplayStockItems.ItemHeight = 25;
            listBoxDisplayStockItems.Location = new Point(12, 359);
            listBoxDisplayStockItems.Name = "listBoxDisplayStockItems";
            listBoxDisplayStockItems.Size = new Size(762, 79);
            listBoxDisplayStockItems.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(291, 258);
            button2.Name = "button2";
            button2.Size = new Size(151, 36);
            button2.TabIndex = 11;
            button2.Text = "Update Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(465, 258);
            button3.Name = "button3";
            button3.Size = new Size(126, 36);
            button3.TabIndex = 12;
            button3.Text = "Delete Item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBoxDisplayStockItems);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxItemCode);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private TextBox textBoxItemCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ListBox listBoxDisplayStockItems;
        private Button button2;
        private Button button3;
    }
}
