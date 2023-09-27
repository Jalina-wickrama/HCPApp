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
    public partial class StaffPatient : Form
    {
        Functions Con;

        public StaffPatient()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPatient();
        }
        

        private void ShowPatient()
        {
            try
            {
                string Query = "Select * from PatientTbl";
                PatientList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            StaffDoctor staffDoctor = new StaffDoctor();
            staffDoctor.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StaffAppointment staffappointment = new StaffAppointment();
            staffappointment.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstName.Text == "" || LastName.Text == "" || GenderCombo.SelectedIndex == -1 || BGCombo.SelectedIndex == -1 || Contact.Text == "" || MedHistory.Text == "" || Alergies.Text == "")
                {
                    MessageBox.Show("Missing Some of Some or All of The data!");
                }
                else
                {
                    string FName = FirstName.Text;
                    string LName = LastName.Text;
                    string Gender = GenderCombo.SelectedItem.ToString();
                    string BloodGroup = BGCombo.SelectedItem.ToString();
                    string PatientContact = Contact.Text;
                    string MedicalHistory = MedHistory.Text;
                    string Allergies = Alergies.Text;

                    string Query = "INSERT INTO PatientTbl (FirstName, LastName, DoB, Gender, BloodGroup, PatientContact, MedicalHistory, Allergies) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
                    Query = string.Format(Query, FName, LName, DoBPicker.Value.Date.ToString("yyyy-MM-dd"), Gender, BloodGroup, PatientContact, MedicalHistory, Allergies); // Format the date correctly
                    Con.SetData(Query);
                    ShowPatient();
                    MessageBox.Show("Patient Added.");
                    FirstName.Text = "";
                    LastName.Text = "";
                    DoBPicker.Value = DateTime.Now.Date; // Set the date without time
                    GenderCombo.SelectedIndex = -1;
                    BGCombo.SelectedIndex = -1;
                    Contact.Text = "";
                    MedHistory.Text = "";
                    Alergies.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstName.Text == "" || LastName.Text == "" || DoBPicker.Value == null || GenderCombo.SelectedIndex == -1 || BGCombo.SelectedIndex == -1 || Contact.Text == "" || MedHistory.Text == "" || Alergies.Text == "")
                {
                    MessageBox.Show("Missing Some or All of the Data!");
                }
                else
                {
                    int patientId = Convert.ToInt32(btnUpdate.Tag);

                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Utente\Documents\HealthCarePlusdb.mdf;Integrated Security=True;Connect Timeout=30";

                    int rowsAffected = Con.UpdatePatientInfo(patientId, FirstName.Text, LastName.Text, DoBPicker.Value, GenderCombo.SelectedItem.ToString(), BGCombo.SelectedItem.ToString(), Contact.Text, MedHistory.Text, Alergies.Text, connectionString);

                    if (rowsAffected > 0)
                    {
                        ShowPatient();
                        MessageBox.Show("Patient Updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient information.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
