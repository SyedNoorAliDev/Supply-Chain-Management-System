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
    public partial class UpdatePayments : Form
    {
        public UpdatePayments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                UpdateAmount um = new UpdateAmount();
                um.ShowDialog();
            }
            else if (radioButton2.Checked == true) {
                UpdateDate um = new UpdateDate();
                um.ShowDialog();
            }
        }
    }
}
