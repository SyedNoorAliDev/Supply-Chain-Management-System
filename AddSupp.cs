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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supply_Management_System
{
    public partial class AddSupp : Form
    {
        public AddSupp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True");
            connection.Open();
            command.Connection = connection;
            try
            {
                command.CommandText = "INSERT INTO Suppliers(supplier_id, supplier_name, supplier_address) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           


        }
    }
}
