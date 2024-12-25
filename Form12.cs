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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Categories";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Customers";
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
            string query = "SELECT * FROM Orders";
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
            string query = "SELECT * FROM Reviews";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Shipments";
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
            string query = "SELECT * FROM Payments";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Supply Management;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection1;
            adapter = new SqlDataAdapter();
            string query = "SELECT * FROM Inventory";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection1);
            DataTable employeesTable = new DataTable();
            adapter.Fill(employeesTable);
            dataGridView1.DataSource = employeesTable;
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
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
    }
}
