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

namespace WindowsFormsApp3
{
    public partial class SalesPerons_CarTools : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public SalesPerons_CarTools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SalesPerons_CarTools_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ShowCarsBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(@"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS; Initial Catalog = Car Dealership; Integrated Security = True; "))
            {
                SqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM MakeModelID", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                sqlDa = new SqlDataAdapter("Select * FROM ColorID", SqlCon);
                DataTable dtb2 = new DataTable();
                sqlDa.Fill(dtb2);

                dataGridView2.DataSource = dtb2;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            if (ModelTB.Text.Equals("") || MakeTB.Text.Equals(""))
            {
                label1.Text = "THIS";
            }
            else
            {
                con = new SqlConnection(@"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into MakeModelID(Make,Model) VALUES ('" + MakeTB.Text + "','" + ModelTB.Text +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into ColorID(Color) VALUES ('" + ColorTB.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
