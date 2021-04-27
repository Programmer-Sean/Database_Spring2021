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





    




    public partial class Customer_Login : Form
    {

        public static string UserName = "";

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        bool newUser = false;

        public Customer_Login()
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

        private void FirstNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UserName = UserNameTB.Text;
            //new CustomerMain().Show();
            //this.Hide();
            string LoginExists = "";

            String EnPW = "";

            string usedUserName = "FALSE";

            if (newUser)
            {
                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                //cmd = new SqlCommand("insert into SalesPersonID([First Name],[Last Name],UserName,Password) values ('" + FirstNameTB.Text + "','" + LastNameTB.Text + "','" + UserNameTB.Text + "','" + PasswordTB.Text + "')", con);

                //New Encrypted sql commands



                //Error Checking for empty Text boxes
                if (UserNameTB.Text == "") return;

                //Error check for already taken username
                cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM CustomerID WHERE ([Username] = '" + UserNameTB.Text + "')) THEN 'TRUE'  ELSE 'FALSE' END", con);
                usedUserName = (string)cmd.ExecuteScalar();


                EnPW = Encrypt.EncryptString(PasswordTB.Text, "Password");
                if (usedUserName.Equals("FALSE"))
                {
                    cmd = new SqlCommand("insert into CustomerID([First Name],[Last Name],UserName,Password) values ('" + FirstNameTB.Text + "','" + LastNameTB.Text + "','" + UserNameTB.Text + "','" + EnPW + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }


            //Login, check login and password
            EnPW = Encrypt.EncryptString(PasswordTB.Text, "Password");
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM CustomerID WHERE ([Username] = '" + UserNameTB.Text + "') AND ([Password] = '" + EnPW + "')  ) THEN 'TRUE'  ELSE 'FALSE' END", con);

            //Holds True/false if statement is in the table
            LoginExists = (string)cmd.ExecuteScalar();

            con.Close();


            if (LoginExists.Equals("TRUE") && usedUserName.Equals("FALSE"))
            {

                UserName = UserNameTB.Text;
                new CustomerMain().Show();
                this.Hide();
            }
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {

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
    }
}
