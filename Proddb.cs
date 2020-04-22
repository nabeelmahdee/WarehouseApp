/*
Warehouse assignment 
PROG 37721 C# and .NET
Group Members:
Alexander Kearney   991579862
Nabeel Ahmed Mahdee 991532760
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp
{
    class Proddb
    {
        //Database connection utility
        private SqlConnection con;
        private SqlDataReader rd;

        //Open connection to database
        public void openCon()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source = DESKTOP-D2DDF61; Initial Catalog = STORE_PRODUCT; Integrated Security=True";
            con.Open();
        }

        //Search products in database
        public Product searchProducts(string name)
        {
            SqlCommand cmd = new SqlCommand($"SELECT PRD_CATEGORY,PRD_NAME,PRD_DESCRIPTION,PRD_SALE,PRD_PRICE FROM PRODUCTS WHERE PRD_NAME='{name}'", con);
            rd = cmd.ExecuteReader();
            Product query = null;
            while (rd.Read())
            {
                query = new Product(rd["PRD_CATEGORY"].ToString(), rd["PRD_NAME"].ToString(), rd["PRD_DESCRIPTION"].ToString(), bool.Parse(rd["PRD_SALE"].ToString()), int.Parse(rd["PRD_PRICE"].ToString()));
            }
            return query;
        }

        //Check login information
        public bool login(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand($"SELECT USERID FROM USERS WHERE USERID='{user}' AND USERPASSWORD='{pass}'", con);
            rd = cmd.ExecuteReader();
            int count = 0;
            while (rd.Read())
            {
                count++;
            }

            if (count==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Close connection to database
        public void closeCon()
        {
            con.Close();
        }

    }
}
