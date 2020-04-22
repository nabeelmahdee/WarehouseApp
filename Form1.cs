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
using System.Windows.Forms;

namespace WarehouseApp
{
    public partial class Form1 : Form
    {
        //Database connection utility
        Proddb dbcon = new Proddb();

        public Form1()
        {
            InitializeComponent();
        }

        //Login button clicked
        private void Login_Click(object sender, EventArgs e)
        {
            //open connection to database
            dbcon.openCon();

            //check if login information is correct
            if (dbcon.login(uid.Text, password.Text))
            {
                //move to second form
                //hide form 1
                this.Hide();
                //get form 2
                Form2 f2 = new Form2();
                //add on close event for form2
                f2.Closed += (s, args) => this.Close();
                //show form 2
                f2.Show();
            }
            else
            {
                //display incorrect login information
                MessageBox.Show("Invalid Login information");
            }
            //close database connection
            dbcon.closeCon();
        }
    }
}
