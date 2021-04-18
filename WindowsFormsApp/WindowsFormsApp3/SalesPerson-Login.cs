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
    public partial class SalesLogin : Form
    {

        string connectionString = @"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS; Initial Catalog = Car Dealership; Integrated Security = True; ";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        bool newUser = false;

        public SalesLogin()
        {
            InitializeComponent();


            //Initial hidden objects
            label4.Hide();
            label5.Hide();
            FirstNameTB.Hide();
            LastNameTB.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SalesPersonMain().Show();
            this.Hide();

            /*
             Check if the login information is correct
            
             */

            //Check if new user is selected or not, BOOL 

            string LoginExists = "";

            if (newUser)
            {
                con = new SqlConnection(@"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into SalesPersonID([First Name],[Last Name],UserName,Password) values ('" + FirstNameTB.Text + "','" + LastNameTB.Text + "','" + UserNameTB.Text + "','" + PasswordTB.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


            //Login, check login and password

            con = new SqlConnection(@"Data Source=DESKTOP-U6DDQFE\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            //cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM SalesPersonID WHERE ([First Name] = 'Sean') AND ([Last Name] = 'Sean')  ) THEN 'TRUE'  ELSE 'FALSE' END", con);
            cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM SalesPersonID WHERE ([Username] = '"+UserNameTB.Text+"') AND ([Password] = '"+PasswordTB.Text+"')  ) THEN 'TRUE'  ELSE 'FALSE' END", con);

            //Holds True/false if statement is in the table
            LoginExists = (string)cmd.ExecuteScalar();
            con.Close();
            


            if (LoginExists.Equals("TRUE"))
            {
                new SalesPersonMain().Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser = true;
            button1.Enabled = false;
            label2.Text = "New Username:";
            label3.Text = "New Password:";

            label4.Show();
            label5.Show();
            FirstNameTB.Show();
            LastNameTB.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
