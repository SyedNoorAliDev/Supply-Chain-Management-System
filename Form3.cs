using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string username = "";
        public static string password = "";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Supply Management; Integrated Security = True");
                username = richTextBox1.Text;
                password = richTextBox2.Text;
                if (username == "" || password == "")
                {
                    MessageBox.Show("Please enter your username and password.");
                }
                else
                {
                    var datasource = @"(local)\SQLEXPRESS";
                    var database = "Supply Management";
                    var thisUsername = username;
                    var thisPassword = password;
                    string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                    SqlConnection conn = new SqlConnection(connString);

                    try
                    {
                        conn.Open();
                        MessageBox.Show("Connection Successful");
                        Form6 frm6 = new Form6();
                        frm6.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
