using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Form7()
        {
            InitializeComponent();
            int ID = 0;
            using (SqlConnection SqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True"))
            {
                SqlCon.Open();

                //Get
                cmd = new SqlCommand("SELECT * FROM CustomerID WHERE ([Username] = '" + Customer_Login.UserName + "')", SqlCon);
                ID = (int)cmd.ExecuteScalar();
                //End
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT SoldID.[Sold ID], CustomerID.[First Name], CustomerID.[Last Name], MakeModelID.Make, MakeModelID.Model, CarID.Price, SalesPersonID.[Sales Person ID] FROM SoldID inner JOIN CustomerID on SoldID.[Customer ID] = CustomerID.[Customer ID] inner JOIN CarID on CarID.[Car ID] = SoldID.[Car ID] inner JOIN MakeModelID on MakeModelID.[Make Model ID] = CarID.[Make Model ID] inner JOIN SalesPersonID on SoldID.[Sales Person ID] = SalesPersonID.[Sales Person ID] where CustomerID.[First Name] = '"+Customer_Login.UserName+"'", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                SqlCon.Close();
            }


            SqlConnection SqlCon2 = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            SqlCon2.Open();
            cmd = new SqlCommand("SELECT SUM([Sold Price]) FROM SoldID where SoldID.[Customer ID] = '"+ID+"'; ", SqlCon2);
            int ID2 = (int)cmd.ExecuteScalar();
            SqlCon2.Close();

            label1.Text = ID2+"";


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new CustomerMain().Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
