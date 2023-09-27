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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet9.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hCPAppDBDataSet9.rooms);

        }
    }
}
