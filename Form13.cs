using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Management_System
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdatePayments upay = new UpdatePayments(); 
            upay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            revertShipping rs = new revertShipping();  
            rs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteShip ds = new DeleteShip();   
            ds.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSupp ab = new AddSupp();
            ab.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPayments ap = new  AddPayments();
            ap.ShowDialog();
        }
    }
}
