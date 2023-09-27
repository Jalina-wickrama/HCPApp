using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HCPApp
{
    public partial class DoctorForm : Form
    {

        Functions Con;
        public DoctorForm()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDoctors();
        }

        private void ShowDoctors()
        {
            try
            {
                string Query = "Select * from DoctorTbl";
                DoctorList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
       

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || ComboSpec.SelectedIndex == -1 || ComboDay.SelectedIndex == -1 || ComboTime.SelectedIndex == -1 || txtQualification.Text == "" || txtContact.Text == "")
                {
                    MessageBox.Show("Missing Some of Some or All of The data!");
                }
                else
                {
                    string FName = txtFirstName.Text;
                    string LName = txtLastName.Text;
                    string Specification = ComboSpec.SelectedItem.ToString();
                    string AvailableDay = ComboDay.SelectedItem.ToString();
                    string AvailableTime = ComboTime.SelectedItem.ToString();
                    string Qualify = txtQualification.Text;
                    string Conta = txtContact.Text;
                    string Query = "INSERT INTO DoctorTbl ( FirstName, LastName, Specification, AvailableDay, AvailableTime, Qualification, Contact) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
                    Query = string.Format(Query, FName, LName, Specification, AvailableDay, AvailableTime, Qualify, Conta);
                    Con.SetData(Query);
                    ShowDoctors();
                    MessageBox.Show("Doctor Added.");
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    ComboSpec.SelectedIndex = -1;
                    ComboDay.SelectedIndex = -1;
                    ComboTime.SelectedIndex = -1;
                    txtQualification.Text = "";
                    txtContact.Text = "";



                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DoctorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DoctorList.Rows[e.RowIndex];

                txtFirstName.Text = selectedRow.Cells[1].Value.ToString();
                txtLastName.Text = selectedRow.Cells[2].Value.ToString();
                ComboSpec.SelectedItem = selectedRow.Cells[3].Value.ToString();
                ComboDay.SelectedItem = selectedRow.Cells[4].Value.ToString();
                ComboTime.SelectedItem = selectedRow.Cells[5].Value.ToString();
                txtQualification.Text = selectedRow.Cells[6].Value.ToString();
                txtContact.Text = selectedRow.Cells[7].Value.ToString();

                int doctorId = Convert.ToInt32(selectedRow.Cells[0].Value);

                Updatebtn.Tag = doctorId.ToString();
            }
        }

        

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || ComboSpec.SelectedIndex == -1 || ComboDay.SelectedIndex == -1 || ComboTime.SelectedIndex == -1 || txtQualification.Text == "" || txtContact.Text == "")
                {
                    MessageBox.Show("Missing Some or All of the Data!");
                }
                else
                {
                    int doctorId = Convert.ToInt32(Updatebtn.Tag); // Assuming the doctor ID is stored in the Tag property

                    string connectionString = @"Data Source=LAPTOP-A9K7TF0H\SQLEXPRESS;Initial Catalog=HCPAppDB;Integrated Security=True";

                    int rowsAffected = Con.UpdateDoctorInfo(doctorId, txtFirstName.Text, txtLastName.Text, ComboSpec.SelectedItem.ToString(), ComboDay.SelectedItem.ToString(), ComboTime.SelectedItem.ToString(), txtQualification.Text, txtContact.Text, connectionString);

                    if (rowsAffected > 0)
                    {
                        ShowDoctors();
                        MessageBox.Show("Doctor Updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update doctor information.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int doctorId = Convert.ToInt32(Updatebtn.Tag);

                    string connectionString = @"Data Source=LAPTOP-A9K7TF0H\SQLEXPRESS;Initial Catalog=HCPAppDB;Integrated Security=True";

                    int rowsAffected = Con.DeleteDoctor(doctorId, connectionString);

                    if (rowsAffected > 0)
                    {
                        ShowDoctors();
                        MessageBox.Show("Doctor Deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete doctor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCPAppDBDataSet2.DoctorTbl' table. You can move, or remove it, as needed.
            this.doctorTblTableAdapter.Fill(this.hCPAppDBDataSet2.DoctorTbl);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DoctorList.Rows[e.RowIndex];
                txtFirstName.Text = selectedRow.Cells[1].Value.ToString();
                txtLastName.Text = selectedRow.Cells[2].Value.ToString();
                ComboSpec.SelectedItem = selectedRow.Cells[3].Value.ToString();
                ComboDay.SelectedItem = selectedRow.Cells[4].Value.ToString();
                ComboTime.SelectedItem = selectedRow.Cells[5].Value.ToString();
                txtQualification.Text = selectedRow.Cells[6].Value.ToString();
                txtContact.Text = selectedRow.Cells[7].Value.ToString();

                int doctorId = Convert.ToInt32(selectedRow.Cells[0].Value);

                Updatebtn.Tag = doctorId.ToString();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }
    }
}
