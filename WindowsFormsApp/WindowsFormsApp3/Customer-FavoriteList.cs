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
    public partial class FavoriteList : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


        public FavoriteList()
        {
            InitializeComponent();

            using (SqlConnection SqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True"))
            {
                SqlCon.Open();

                //Get
                cmd = new SqlCommand("SELECT * FROM CustomerID WHERE ([Username] = '" + Customer_Login.UserName + "')", SqlCon);
                int ID = (int)cmd.ExecuteScalar();
                //End
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM PotentialSaleID WHERE [Customer ID] = " + ID + "", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                SqlCon.Close();
            }

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new CustomerMain().Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FavoriteList_Load(object sender, EventArgs e)
        {

        }

        string curCarID = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInbdex = e.RowIndex;


            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
                string value = row.Cells["Potential Sale ID"].Value.ToString();
                curCarID = value;
                label1.Text = curCarID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Does not refresh the table after deleting but does remove the value from the database +)
            //DELETE FROM table_name WHERE condition;

            SqlConnection SqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            SqlCon.Open();

            

            if (curCarID != "")
            {
                cmd = new SqlCommand("DELETE FROM PotentialSaleID WHERE [Potential Sale ID] = " + curCarID + "", SqlCon);
                cmd.ExecuteNonQuery();
            }
            SqlCon.Close();
            refreshTable();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            //add car to soldID 
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();

            if (curCarID != "")
            {
                //getting customerID
                cmd = new SqlCommand("SELECT [Customer ID] FROM PotentialSaleID WHERE ([Potential Sale ID] = '" + curCarID + "')", con);
                int tempCustomerID = (int)cmd.ExecuteScalar();

                //getting carID
                cmd = new SqlCommand("SELECT [Car ID] FROM PotentialSaleID WHERE ([Potential Sale ID] = '" + curCarID + "')", con);
                int tempCarID = (int)cmd.ExecuteScalar();

                //getting Sold Price
                cmd = new SqlCommand("SELECT [Price] FROM CarID WHERE ([Car ID] = '" + tempCarID + "')", con);
                int tempPrice = (int)cmd.ExecuteScalar();

                //get Sales Person ID

                int tempsSalesPersonID = 0;

                //cmd = new SqlCommand("insert into PotentialSaleID([Customer ID],[Car ID]) values(" + ID + "," + curCarID + ");", con);

                cmd = new SqlCommand("insert into SoldID([Customer ID],[Car ID],[Sold Price],[Sales Person ID]) values(" + tempCustomerID + "," + tempCarID + "," + tempPrice + "," + tempsSalesPersonID + ");", con);
                cmd.ExecuteNonQuery();



                //remove car from ALL potential sales
                cmd = new SqlCommand("DELETE FROM PotentialSaleID WHERE [Car ID] = " + tempCarID + "", con);
                cmd.ExecuteNonQuery();
            }
        }

        private void refreshTable()
        {
            using (SqlConnection SqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True"))
            {
                SqlCon.Open();

                //Get
                cmd = new SqlCommand("SELECT * FROM CustomerID WHERE ([Username] = '" + Customer_Login.UserName + "')", SqlCon);
                int ID = (int)cmd.ExecuteScalar();
                //End
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM PotentialSaleID WHERE [Customer ID] = " + ID + "", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                SqlCon.Close();
            }
        }
    }
}
