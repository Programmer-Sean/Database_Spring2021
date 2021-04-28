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
    public partial class Form2 : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();



            //filling datagridview
            String temp = "SELECT CustomerID.[First Name], CustomerID.[Last Name], CarID.[Car ID], MakeModelID.Make, MakeModelID.Model, ColorID.Color, CarID.Mileage,CarID.Price, LotID.[Lot Name], LotID.[Lot Street Name] FROM CustomerID inner JOIN PotentialSaleID ON CustomerID.[Customer ID] = PotentialSaleID.[Customer ID] inner join CarID on CarID.[Car ID] = PotentialSaleID.[Car ID]  inner join MakeModelID  on CarID.[Make Model ID] = MakeModelID.[Make Model ID] inner join ColorID  on CarID.[Color ID] = ColorID.[Color ID]  inner join LotCarID on CarID.[Car ID] = LotCarID.[Car ID] inner join LotID on LotID.[Lot ID] = LotCarID.[Lot ID]";

            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(temp, con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;


            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
