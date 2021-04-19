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
    

    public partial class SalesPersonAddLot : Form
    {

        string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public SalesPersonAddLot()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewLots_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                SqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM LOTID", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }

        private void InsertLot_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("insert into LotID([Lot Name],[Lot Number],[Lot Street Name],City) values ('" + txtName.Text + "','" + numBox.Text + "','" + txtStName.Text + "','" + txtCityName.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            
            //Update the list view
            ViewLots_Click(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
