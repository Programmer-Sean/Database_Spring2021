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
    public partial class SalesLogin : Form
    {

        //string connectionString = "";// @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
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
            //new SalesPersonMain().Show();
           // this.Hide();

            /*
             Check if the login information is correct
            
             */

            //Check if new user is selected or not, BOOL 

            string LoginExists = "";

            String EnPW = "";

            if (newUser)
            {
                con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
                con.Open();
                //cmd = new SqlCommand("insert into SalesPersonID([First Name],[Last Name],UserName,Password) values ('" + FirstNameTB.Text + "','" + LastNameTB.Text + "','" + UserNameTB.Text + "','" + PasswordTB.Text + "')", con);

                //New Encrypted sql commands

                EnPW = Encrypt.EncryptString(PasswordTB.Text, "Password");

                cmd = new SqlCommand("insert into SalesPersonID([First Name],[Last Name],UserName,Password) values ('" + FirstNameTB.Text + "','" + LastNameTB.Text + "','" + UserNameTB.Text + "','" + EnPW + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


            //Login, check login and password
            EnPW = Encrypt.EncryptString(PasswordTB.Text, "Password");
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Car Dealership;Integrated Security=True");
            con.Open();
            //cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM SalesPersonID WHERE ([First Name] = 'Sean') AND ([Last Name] = 'Sean')  ) THEN 'TRUE'  ELSE 'FALSE' END", con);
            cmd = new SqlCommand("SELECT CASE WHEN EXISTS   ( SELECT * FROM SalesPersonID WHERE ([Username] = '"+UserNameTB.Text+"') AND ([Password] = '"+ EnPW +"')  ) THEN 'TRUE'  ELSE 'FALSE' END", con);

            //Holds True/false if statement is in the table
            LoginExists = (string)cmd.ExecuteScalar();

            con.Close();

            //label1.Text = Encrypt.EncryptString(PasswordTB.Text, "Password");
            //label2.Text = Encrypt.DecryptString(label1.Text, "Password");


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

    //Test Area
    public static class Encrypt
    {
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private const string initVector = "pemgail9uzpgzl88";
        // This constant is used to determine the keysize of the encryption algorithm
        private const int keysize = 256;
        //Encrypt
        public static string EncryptString(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        //Decrypt
        public static string DecryptString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
