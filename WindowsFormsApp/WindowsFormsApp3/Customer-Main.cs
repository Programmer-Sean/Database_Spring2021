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
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    public partial class CustomerMain : Form
    {
        bool checkedfirst = true;

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public CustomerMain()
        {
            InitializeComponent();




            //label1.Text = Customer_Login.UserName;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            string Sql = "SELECT [Make] from MakeModelID";
            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

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
                colorTxtBox.Items.Add(DR[0]);
            }

            Sql = "SELECT Model FROM MakeModelID";
            conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            conn.Open();
            cmd = new SqlCommand(Sql, conn);
            DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                modelTxtBox.Items.Add(DR[0]);
            }

            DR.Close();
            //Chart code
            int count = 0;
            List<string> seriesArray = new List<string>();
            List<int> pointsArray = new List<int>();

            cmd = new SqlCommand("SELECT[Color] FROM ColorID", conn);
            DR = cmd.ExecuteReader();

            this.chart1.Titles.Add("Colors of Cars");
            while (DR.Read())
            {
                seriesArray.Add(DR[0].ToString());
                count++;
            }
            DR.Close();
            for (int p = 1; p <= count; p++)
            {
                cmd = new SqlCommand("SELECT Count ([Color ID]) From CarID WHERE [Color ID]=" + p + ";", conn);
                pointsArray.Add((int)cmd.ExecuteScalar());

            }
            label1.Text = pointsArray[0].ToString();
            for (int i = 0; i < count; i++)
            {
                Series colors = this.chart1.Series.Add(seriesArray[i]);
                colors.Points.Add(pointsArray[i]);
            }

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
            List<int> MakeModelIDsList = new List<int>();
            int numofIDs = -1;

            if (makeTxtBox.Text == "" && modelTxtBox.Text == "" && priceMinBox.Value == 0 && priceMaxBox.Value == 0 && colorTxtBox.Text == "" && carLotTxtBox.Text == "" && carMileage.Value == 0)
            {
                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM CarID", con);
                //Working one
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CarID WHERE[Make Model ID] = " + "[Make Model ID]" + " AND [Color ID] = " + "[Color ID]" + " AND Mileage = " + tempMile + " AND Price = " + tempPrice + "", con);



                //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CarID,LotCarID WHERE[Make Model ID] = " + "[Make Model ID]" + " AND [Color ID] = " + "[Color ID]" + " AND Mileage = " + tempMile + " AND Price = " + tempPrice + " AND CarID.[Car ID] = LotCarID.[Car ID]", con);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (makeTxtBox.Text != "" && modelTxtBox.Text == "")
            {
                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();

                //Getting all the MakeModel Ids based on selected Make
                string Sql = "SELECT [Make Model ID] FROM MakeModelID WHERE([Make] = '" + makeTxtBox.Text + "')";

                SqlCommand cmd = new SqlCommand(Sql, con);
                SqlDataReader DR = cmd.ExecuteReader();


                while (DR.Read())
                {
                    MakeModelIDsList.Add(DR.GetInt32(0));
                    numofIDs++;
                }
                DR.Close();


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
                con.Close();

                ArrayList sequence = new ArrayList();
                try
                {
                    int i = 0;
                    con = new SqlConnection();
                    con.ConnectionString = (@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    while (i <= numofIDs)
                    {
                        cmd.CommandText = "SELECT* FROM CarID WHERE[Make Model ID] = " + MakeModelIDsList[i] + " AND[Color ID] = " + tempColorID + " AND(Mileage <= " + carMileage.Value + ") AND(Price BETWEEN " + priceMinBox.Value + " AND " + priceMaxBox.Value + ")";


                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            DataSequence d = new DataSequence();
                            d.ID = (int)reader[0];
                            d.MakeModelID = (int)reader[1];
                            d.VIN = (int)reader[2];
                            d.ColorID = (int)reader[3];
                            d.Mileage = (int)reader[4];
                            d.Price = (int)reader[5];
                            d.Picture = reader[6].ToString();
                            sequence.Add(d);

                        }
                        i++;
                        reader.Close();
                    }
                    dataGridView1.DataSource = sequence;
                }
                finally
                {
                    con.Close();
                }


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

        private void carLotTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makeTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void modelTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void modelTxtBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string temp;
            if (checkedfirst)
            {
                checkedfirst = false;
                SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Make FROM MakeModelID WHERE([Model] = '" + modelTxtBox.Text + "')", conn);
                temp = cmd.ExecuteScalar().ToString();
                makeTxtBox.Text = temp;
            }
            if (!checkedfirst)
            {
                checkedfirst = true;
                return;
            }
        }

        private void makeTxtBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Reseting the combobox values
            if (checkedfirst)
            {
                modelTxtBox.Items.Clear();
                modelTxtBox.ResetText();


                string Sql = "SELECT Model FROM MakeModelID WHERE([Make] = '" + makeTxtBox.Text + "')";
                SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    modelTxtBox.Items.Add(DR[0]);
                }
                checkedfirst = false;
            }
            if (!checkedfirst)
            {
                checkedfirst = true;
                return;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

public class DataSequence
{

    private int id;

    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    private int makeModelID;

    public int MakeModelID
    {
        get { return makeModelID; }
        set { makeModelID = value; }
    }
    private int vin;

    public int VIN
    {
        get { return vin; }
        set { vin = value; }
    }

    private int colorID;

    public int ColorID
    {
        get { return colorID; }
        set { colorID = value; }
    }

    private int mileage;
    public int Mileage
    {
        get { return mileage; }
        set { mileage = value; }
    }
    private int price;
    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    private string picture;
    public String Picture
    {
        get { return picture; }
        set { picture = value; }
    }
}
