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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Products_Categories";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Orders";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Order_Items";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Products";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Suppliers";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
    }
}
