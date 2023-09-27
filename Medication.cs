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
    public partial class Medication : Form
    {
        public Medication()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Medication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet3.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.Fill(this.hCPAppDBDataSet3.Medication);

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
