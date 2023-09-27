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
    public partial class Form1 : Form
    {
        private Functions Con;
        public Form1()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool isAdmin = rbAdmin.Checked;

            if (isAdmin)
            {
                if (Con.IsValidAdminCredentials(username, password))
                {
                    // Admin login successful, open admin dashboard
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials. Please try again.");
                }
            }
            else
            {
                if (Con.IsValidStaffCredentials(username, password))
                {
                    string staffMemberName = Con.GetStaffMemberName(username);

                    if (!string.IsNullOrEmpty(staffMemberName))
                    {
                        // Staff login successful, open staff dashboard and pass staffMemberName
                        StaffDashboard staffDashboard = new StaffDashboard(staffMemberName);
                        staffDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid staff credentials. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid staff credentials. Please try again.");
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
