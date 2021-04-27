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
    public partial class CustomerMain : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public CustomerMain()
        {
            InitializeComponent();
            label1.Text = Customer_Login.UserName;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        //Search Button
        private void button2_Click(object sender, EventArgs e)
        {


            string tempMakeModelID = "[Make Model ID]";
            string tempColorID = "[Color ID]";
            string tempMile = "Mileage";
            string tempPrice = "Price";


            if (makeTxtBox.Text == "" && modelTxtBox.Text == "" && priceMinBox.Value == 0 && priceMaxBox.Value == 0 && colorTxtBox.Text == "" && carLotTxtBox.Text == "" && carMileage.Value == 0)
            {
                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM CarID", con);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CarID WHERE[Make Model ID] = " + "[Make Model ID]" + " AND [Color ID] = " + "[Color ID]" + " AND Mileage = " + tempMile + " AND Price = " + tempPrice + "", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                cmd.ExecuteNonQuery();
                con.Close();
            }

            else
            {


                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                //Getting Make Model ID
                if (makeTxtBox.Text != "" && modelTxtBox.Text != "")
                {
                    cmd = new SqlCommand("Select [Make Model ID] FROM MakeModelID WHERE ([Make] = '" + makeTxtBox.Text + "') AND ([Model] = '" + modelTxtBox.Text + "')", con);
                    tempMakeModelID = cmd.ExecuteScalar().ToString();
                }


                ///Getting ColorID
                if (colorTxtBox.Text != "")
                {
                    cmd = new SqlCommand("Select [Color ID] FROM ColorID WHERE ([Color] = '" + colorTxtBox.Text + "')", con);
                    tempColorID = cmd.ExecuteScalar().ToString();
                }
                else
                {
                    tempColorID = "[Color ID]";
                }

                if (priceMaxBox.Value == 0)
                {
                    priceMaxBox.Value = 1000000;
                }

                if (carMileage.Value == 0)
                {
                    carMileage.Value = 1000000;
                }
                cmd = new SqlCommand("SELECT * FROM CarID", con);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CarID WHERE[Make Model ID] = " + tempMakeModelID + " AND [Color ID] = " + tempColorID + " AND (Mileage <= " + carMileage.Value + ") AND (Price BETWEEN " + priceMinBox.Value + " AND " + priceMaxBox.Value + ")", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //Setting new Last Name of User
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
             * UPDATE CustomerID 
                SET 
                    [Last Name] = 'Hill'
                WHERE
                    Username = 'admin';
            */

            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("UPDATE CustomerID SET [Last Name] = '" + ChangeLastNameTB.Text + "' WHERE ([Username] = '" + Customer_Login.UserName + "') ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void carMileage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        string curCarID = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInbdex = e.RowIndex;


            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
                string value = row.Cells["Car ID"].Value.ToString();
                curCarID = value;
                label9.Text = value;
            }

        }

        private void favouriteBtn_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();

            //Getting Customer ID
            cmd = new SqlCommand("SELECT * FROM CustomerID WHERE ([Username] = '" + Customer_Login.UserName + "')", con);
            int ID = (int)cmd.ExecuteScalar();
            //End

            if (curCarID != "")
            {
                cmd = new SqlCommand("insert into PotentialSaleID([Customer ID],[Car ID]) values(" + ID + "," + curCarID + ");", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            new FavoriteList().Show();
            this.Hide();

        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
