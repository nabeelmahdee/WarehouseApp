namespace WarehouseApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.OnSale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Product Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 31);
            this.textBox1.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(372, 46);
            this.Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(152, 44);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 567);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add To Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 569);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 77);
            this.button3.TabIndex = 5;
            this.button3.Text = "Purchase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "On Sale:";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(172, 119);
            this.ProdName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(348, 31);
            this.ProdName.TabIndex = 10;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(172, 190);
            this.Category.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(348, 31);
            this.Category.TabIndex = 11;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(172, 258);
            this.Description.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(348, 108);
            this.Description.TabIndex = 12;
            // 
            // OnSale
            // 
            this.OnSale.Location = new System.Drawing.Point(172, 388);
            this.OnSale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OnSale.Name = "OnSale";
            this.OnSale.Size = new System.Drawing.Size(348, 31);
            this.OnSale.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price:";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(172, 444);
            this.Price.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(348, 31);
            this.Price.TabIndex = 15;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(172, 508);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(348, 31);
            this.Quantity.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OnSale);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Warehouse App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox OnSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label7;
    }
}