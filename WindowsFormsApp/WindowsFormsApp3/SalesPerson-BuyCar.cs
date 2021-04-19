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
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();


            string Sql = "SELECT [Lot ID] from LotID";
            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                dealerTxtBox.Items.Add(DR[0]);
                LotFilterTB.Items.Add(DR[0]);
            }







            //Getting list of models for combobox
            Sql = "SELECT [Make] from MakeModelID";
            conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            cmd = new SqlCommand(Sql, conn);
            DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                if (!makeTxtBox.Items.Contains(DR[0]))
                {
                    makeTxtBox.Items.Add(DR[0]);
                }
            }






            //Getting list of Colors for combobox
            Sql = "SELECT [Color] from ColorID";
            conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            cmd = new SqlCommand(Sql, conn);
            DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                ColorComboBox.Items.Add(DR[0]);
            }






            

            //Hiding Stuff
            FilterLabel.Hide();
            LotFilterTB.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecting from combobox activates this code

        }

        private void GetCars_Click(object sender, EventArgs e)
        {
            FilterLabel.Hide();
            LotFilterTB.Hide();

            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM CarID", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            
            dataGridView1.DataSource = dtbl;


            con.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //;ColorComboBox`
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();

            //cmd = new SqlCommand("insert into CarID(MakeModelID,[VIN Number], [Color ID], Mileage, Price, Picture) VALUES ('" + MakeTB.Text + "','" + ModelTB.Text + "')", con);

            cmd = new SqlCommand ("Select [Make Model ID] FROM MakeModelID WHERE ([Make] = '" + makeTxtBox.Text + "') AND ([Model] = '" + modelTxtBox.Text + "')", con);
            int temp = (int)cmd.ExecuteScalar();
            //label2.Text = temp + "";

            ///Getting ColorID
            cmd = new SqlCommand("Select [Color ID] FROM ColorID WHERE ([Color] = '" + ColorComboBox.Text + "')", con);
            int temp2 = (int)cmd.ExecuteScalar();

            //label1.Text = temp2+"";

            cmd = new SqlCommand("insert into CarID([Make Model ID],[VIN Number], [Color ID], Mileage, Price, Picture) VALUES ('" + temp + "','" + VinTB.Text + "' ,'" + temp2 + "','" + MileageTB.Text + "','" + PriceTB.Text + "','" + PictureTB.Text + "')", con);
            cmd.ExecuteNonQuery();




            //Getting temp carID
            cmd = new SqlCommand("Select [Car ID] FROM CarID WHERE ([VIN Number] = '" + VinTB.Text + "')", con);
            int temp3 = (int)cmd.ExecuteScalar();


            cmd = new SqlCommand("insert into LotCarID([Lot ID], [Car ID]) VALUES ('" + dealerTxtBox.Text + "','" + temp3 + "')", con);

            cmd.ExecuteNonQuery();


            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void makeTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reseting the combobox values
            modelTxtBox.Items.Clear();
            modelTxtBox.ResetText();


            string Sql = "SELECT Model FROM MakeModelID WHERE([Make] = '"+makeTxtBox.Text+"')";
            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                modelTxtBox.Items.Add(DR[0]);
            }
        }

        private void colorTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM LotCarID", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;


            FilterLabel.Show();
            LotFilterTB.Show();
            con.Close();
        }

        private void LotFilterTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM LotCarID WHERE [Lot ID] = ' " + LotFilterTB.Text + " '", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
