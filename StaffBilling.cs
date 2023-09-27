using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCPApp
{
    public partial class StaffBilling : Form
    {
        public StaffBilling()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void StaffBilling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet5.billing' table. You can move, or remove it, as needed.
            this.billingTableAdapter.Fill(this.hCPAppDBDataSet5.billing);

        }
    }
}
