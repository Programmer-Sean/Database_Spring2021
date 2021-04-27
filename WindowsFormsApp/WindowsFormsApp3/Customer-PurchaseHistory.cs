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
        public Form7()
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
    }
}
