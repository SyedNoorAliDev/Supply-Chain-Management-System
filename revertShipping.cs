﻿using System;
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
    public partial class revertShipping : Form
    {
        public revertShipping()
        {
            InitializeComponent();
        }

        private void revertShipping_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                command.CommandText = String.Format("EXEC dbo.RevertShipmentStatusProcedure @order_id = {0}", textBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Order Status Reverted!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
