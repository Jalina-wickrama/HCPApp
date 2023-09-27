using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCPApp
{
    public partial class AdminDashboard : Form
    {
        Functions Con;

        public AdminDashboard()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDoctors();
        }
        private void ShowDoctors()
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet1.AppointmentTbl' table. You can move, or remove it, as needed.
            this.appointmentTblTableAdapter1.Fill(this.hCPAppDBDataSet1.AppointmentTbl);
            // TODO: This line of code loads data into the 'hCPAppDBDataSet.AppointmentTbl' table. You can move, or remove it, as needed.
            this.appointmentTblTableAdapter.Fill(this.hCPAppDBDataSet.AppointmentTbl);

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        string NewDate = DateTime.Now.ToString("dd/MM/yyyy");


        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Medication medication = new Medication();
            medication.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            diagnosis.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }
    }
}
