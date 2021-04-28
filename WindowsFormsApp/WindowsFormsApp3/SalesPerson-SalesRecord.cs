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

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


        string connectionString = @"Data Source=DESKTOP-0T7V9M3\SQLEXPRESS; Initial Catalog = Car Dealership; Integrated Security = True; ";
        public Form3()
        {
            InitializeComponent();
            SqlConnection SqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");





            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT SalesPersonID.[First Name],SalesPersonID.[Last Name], CustomerID.[First Name], CustomerID.[Last Name], CarID.[Car ID], MakeModelID.Make, MakeModelID.Model, ColorID.Color, CarID.Mileage,CarID.Price FROM SalesPersonID inner JOIN SoldID ON SalesPersonID.[Sales Person ID] = SoldID.[Sales Person ID] inner join CustomerID on CustomerID.[Customer ID] = SoldID.[Customer ID] inner join CarID on SoldID.[Car ID] = CarID.[Car ID] inner join MakeModelID on CarID.[Make Model ID] = MakeModelID.[Make Model ID] inner join ColorID on CarID.[Color ID] = ColorID.[Color ID]", SqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgv1.DataSource = dtbl;
            SqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
