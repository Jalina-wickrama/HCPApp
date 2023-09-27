using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCPApp
{
    public partial class StaffAppointment : Form
    {

        StaffFunction Con;
        public StaffAppointment()
        {
            InitializeComponent();
            Con = new StaffFunction();
            ShowDoctors();
            ShowPatient();
            ShowAppointments();
            ComboSSpec.SelectedIndexChanged += new EventHandler(ComboSSpec_SelectedIndexChanged);
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
        private void ComboSSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpec = ComboSSpec.SelectedItem.ToString();

            DataView dv = new DataView(Con.GetData("Select * from DoctorTbl"));
            dv.RowFilter = $"Specification = '{selectedSpec}'";

            DocData.DataSource = dv;
        }
        private void txtSPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patientFirstName = txtSPatient.Text.Trim();
                string query;

                if (string.IsNullOrEmpty(patientFirstName))
                {
                    // If the TextBox is empty, show all patients
                    query = "SELECT * FROM PatientTbl";
                }
                else
                {
                    // If there's text in the TextBox, filter by first name
                    query = "SELECT * FROM PatientTbl WHERE FirstName LIKE @FirstName";
                }

                DataTable dt = Con.GetData(query);

                if (!string.IsNullOrEmpty(patientFirstName))
                {
                    // If there's text, add a parameter for filtering
                    dt.DefaultView.RowFilter = $"FirstName LIKE '%{patientFirstName}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }

                PatData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSPatient_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string patientFirstName = txtSPatient.Text.Trim();

                DataView dv = new DataView(Con.GetData("SELECT * FROM PatientTbl"));

                if (!string.IsNullOrEmpty(patientFirstName))
                {
                    // If there's text, filter by first name
                    dv.RowFilter = $"FirstName LIKE '%{patientFirstName}%'";
                }
                else
                {
                    // If the TextBox is empty, show all patients
                    dv.RowFilter = string.Empty;
                }

                PatData.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from your form's controls
                int patientId = int.Parse(txtPatId.Text);
                string patFName = txtPatFName.Text;
                string patLName = txtPatLName.Text;
                int doctorId = int.Parse(txtDocId.Text);
                string docFName = txtDocFName.Text;
                string docLName = txtDocLName.Text;
                DateTime appointmentDate = DoBPicker.Value;

                // Call the GetNextAppointmentNumber method to get the next appointment number
                int appointmentNumber = Con.GetNextAppointmentNumber();

                decimal charge = decimal.Parse(txtCharge.Text);

                // Call the AddAppointment method to insert data
                Con.AddAppointment(patientId, patFName, patLName, doctorId, docFName, docLName, appointmentDate, appointmentNumber, charge);

                // Show a success message or perform other actions as needed
                MessageBox.Show("Appointment added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DocData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is clicked
            {
                DataGridViewRow selectedRow = DocData.Rows[e.RowIndex];

                // Fill the text boxes with data from the selected row
                txtDocId.Text = selectedRow.Cells["DoctorId"].Value.ToString();
                txtDocFName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtDocLName.Text = selectedRow.Cells["LastName"].Value.ToString();
            }
        }

        private void PatData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is clicked
            {
                DataGridViewRow selectedRow = PatData.Rows[e.RowIndex];

                // Fill the text boxes with data from the selected row
                txtPatId.Text = selectedRow.Cells["PatientId"].Value.ToString();
                txtPatFName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtPatLName.Text = selectedRow.Cells["LastName"].Value.ToString();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffAppointment_Load(object sender, EventArgs e)
        {

        }

        private void txtPatId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPatLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPatFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void imgSlide_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            StaffPatient staffpatient = new StaffPatient();
            staffpatient.Show();
            this.Hide();
        }

        private void Appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StaffDoctor staffDoctor = new StaffDoctor();
            staffDoctor.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
