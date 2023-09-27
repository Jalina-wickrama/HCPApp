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
    public partial class Appointment : Form
    {
        StaffFunction Con;
        public Appointment()
        {
            InitializeComponent();
            Con = new StaffFunction();
            ShowDoctors();
            ShowPatient();
            ShowAppointments();
        }
        private void ShowDoctors()
        {
            try
            {
                string Query = "Select * from DoctorTbl";
                DocData.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void ShowPatient()
        {
            try
            {
                string Query = "Select * from PatientTbl";
                PatData.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void ShowAppointments()
        {
            try
            {
                string Query = "Select * from AppointmentTbl";
                Appointments.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DocData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
