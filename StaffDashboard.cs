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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard(string staffMemberName)
        {
            InitializeComponent();
            Console.WriteLine($"Received staff member name: {staffMemberName}");

            welcomeLabel.Text = $"Welcome to the Staff Dashboard, {staffMemberName}!";
        }

        public StaffDashboard()
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StaffPatient staffpatient = new StaffPatient();
            staffpatient.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StaffDoctor staffdoc = new StaffDoctor();
            staffdoc.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StaffAppointment staffappointment = new StaffAppointment();
            staffappointment.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            StaffDoctor staffdoc = new StaffDoctor();
            staffdoc.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            StaffPatient staffpatient = new StaffPatient();
            staffpatient.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StaffAppointment staffappointment = new StaffAppointment();
            staffappointment.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StaffBilling staffBilling = new StaffBilling();
            staffBilling.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StaffMedication staffMedication = new StaffMedication();
            staffMedication.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            StaffRooms staffRooms = new StaffRooms();
            staffRooms.Show();
            this.Hide();
        }
    }
}
