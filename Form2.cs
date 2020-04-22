/*
Warehouse assignment 
PROG 37721 C# and .NET
Group Members:
Alexander Kearney   991579862
Nabeel Ahmed Mahdee 991532760
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarehouseApp
{
    public partial class Form2 : Form
    {
        //Database connection utility
        Proddb dbcon = new Proddb();
        //Current product searched
        Product query;
        //Cart list
        List<Product> list = new List<Product>();

        public Form2()
        {
            InitializeComponent();
        }

        //Search button clicked
        private void Search_Click(object sender, EventArgs e)
        {
            //Connect to database
            dbcon.openCon();
            //Get query
            query = dbcon.searchProducts(textBox1.Text);

            //Check results
            if (query!=null)
            {
                //fill textboxes with results
                ProdName.Text = $"{query.name}";
                Category.Text = $"{query.category}";
                Description.Text = $"{query.description}";
                OnSale.Text = $"{query.sale}";
                Price.Text = $"{query.price}";
                Quantity.Text = "1";
            }
            else
            {
                //clear text boxes
                ProdName.Text = "";
                Category.Text = "";
                Description.Text = "";
                OnSale.Text = "";
                Price.Text = "";
                Quantity.Text = "";
                MessageBox.Show("Product not found");

            }
            //close database connection
            dbcon.closeCon();
        }

        //Add to cart button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            //check if a product has been searched
            if (query != null)
            {
                
                //Check if product is already in cart
                bool found = false;
                foreach (Product prod in list)
                {
                    if(prod.name == query.name)
                    {
                        //add quantity to product already in cart
                        prod.quantity += int.Parse(Quantity.Text);
                        found = true;
                        break;
                    }
                }
                //if not in cart add to cart
                if (!found)
                {
                    query.quantity = int.Parse(Quantity.Text);
                    list.Add(query);
                }

                //Display product information
                MessageBox.Show($"{query}");
            }
            else
            {
                //Prompt user to search a product
                MessageBox.Show("Please search a product first");
            }
        }

        //Purchase button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            //check if cart is empty
            if(list.Count != 0)
            {
                //Get all products in cart information
                string s = "Purchase Description:\n\n";
                int total = 0;
                foreach(Product prod in list)
                {
                    s += $"{prod.print()}\n\n";
                    //calculate total price
                    total += prod.price * prod.quantity;
                }

                s += $"total: ${total}";
                //display cart information and total price
                MessageBox.Show(s);
            }
            else
            {
                //display that cart is empty
                MessageBox.Show("No items in cart");
            }
        }
    }   

}
