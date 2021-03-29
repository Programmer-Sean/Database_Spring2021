using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=DESKTOP-0T7V9M3\SQLEXPRESS; Initial Catalog = Car Dealership; Integrated Security = True; ";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }

        private void GetList_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                SqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM SoldID", SqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv1.DataSource = dtbl;
            }
        }
    }
}
