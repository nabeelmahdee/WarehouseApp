/*
Warehouse assignment 
PROG 37721 C# and .NET
Group Members:
Alexander Kearney   991579862
Nabeel Ahmed Mahdee 991532760
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp
{
    class Product
    {
        public string category;
        public string name;
        public string description;
        public bool sale;
        public int price;
        public int quantity;

        //Product Constructor
        public Product(string category, string name, string description, bool sale, int price)
        {
            this.category = category;
            this.name = name;
            this.description = description;
            this.sale = sale;
            this.price = price;
        }

        //Print out Product Values
        override public string ToString()
        {
            string s = $"Name: {name}\n" +
                $"Category: {category}\n" +
                $"Description: {description}\n" +
                $"Price: ${price}\n" +
                $"On Sale: {sale}\n" +
                $"Quantity: {quantity}";
            return s;
        }

        //Print short version
        public string print()
        {
            string s = $"Name: {name}\n" +
                $"Price: ${price}\n" +
                $"Quantity: {quantity}";
            return s;
        }
    }
}
