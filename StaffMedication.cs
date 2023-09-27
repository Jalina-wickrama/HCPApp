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
    public partial class StaffMedication : Form
    {
        public StaffMedication()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void StaffMedication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet8.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.Fill(this.hCPAppDBDataSet8.Medication);

        }
    }
}
