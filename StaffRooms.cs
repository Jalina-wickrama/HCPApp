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
    public partial class StaffRooms : Form
    {
        public StaffRooms()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void imgSlide_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void StaffRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet4.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hCPAppDBDataSet4.rooms);

        }
    }
}
