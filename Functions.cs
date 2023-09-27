using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace HCPApp
{
    class Functions
    {
        public string StaffMemberName { get; private set; }
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;
        public Functions()
        {
            Constr = @"Data Source=DESKTOP-KCIUG84\SQLEXPRESS;Initial Catalog=HCPAppDB;Integrated Security=True";
            Con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }




        //Login Table

        public bool IsValidAdminCredentials(string username, string password)
        {
            string query = "SELECT AdminID FROM AdminTbl WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(Constr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                bool isValid = reader.HasRows;

                reader.Close();
                return isValid;
            }
        }

        public bool IsValidStaffCredentials(string username, string password)
        {
            string query = "SELECT StaffID FROM StaffTbl WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(Constr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                bool isValid = reader.HasRows;

                reader.Close();
                return isValid;
            }
        }
        public string GetStaffMemberName(string username)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                string query = "SELECT FirstName FROM StaffTbl WHERE UserName = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        StaffMemberName = result.ToString();
                    }
                    else
                    {
                        StaffMemberName = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    StaffMemberName = string.Empty;
                }
                finally
                {
                    connection.Close();
                }
            }

            return StaffMemberName;
        }





        //Doctor table

        public int GetDoctorIdByDetails(string firstName, string lastName, string specification, string availableDay, string availableTime)
        {
            int doctorId = -1;

            string query = "SELECT DoctorId FROM DoctorTbl WHERE FirstName = @FirstName AND LastName = @LastName AND Specification = @Specification AND AvailableDay = @AvailableDay AND AvailableTime = @AvailableTime";

            using (SqlConnection connection = new SqlConnection(Constr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Specification", specification);
                command.Parameters.AddWithValue("@AvailableDay", availableDay);
                command.Parameters.AddWithValue("@AvailableTime", availableTime);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    doctorId = Convert.ToInt32(result);
                }
            }

            return doctorId;
        }
        public int UpdateDoctorInfo(int doctorId, string firstName, string lastName, string specification, string availableDay, string availableTime, string qualification, string contact, string connectionString)
        {
            string query = "UPDATE DoctorTbl SET FirstName = @FirstName, LastName = @LastName, Specification = @Specification, AvailableDay = @AvailableDay, AvailableTime = @AvailableTime, Qualification = @Qualification, Contact = @Contact WHERE DoctorId = @DoctorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Specification", specification);
                command.Parameters.AddWithValue("@AvailableDay", availableDay);
                command.Parameters.AddWithValue("@AvailableTime", availableTime);
                command.Parameters.AddWithValue("@Qualification", qualification);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@DoctorId", doctorId);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }

        }

        public int DeleteDoctor(int doctorId, string connectionString)
        {
            string query = "DELETE FROM DoctorTbl WHERE DoctorId = @DoctorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DoctorId", doctorId);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }


        //********************Patient********************* 
        public int UpdatePatientInfo(int patientId, string firstName, string lastName, DateTime dob, string gender, string bloodGroup, string contact, string medicalHistory, string allergies, string connectionString)
        {
            string query = "UPDATE PatientTbl SET FirstName = @FirstName, LastName = @LastName, DoB = @DoB, Gender = @Gender, BloodGroup = @BloodGroup, PatientContact = @PatientContact, MedicalHistory = @MedicalHistory, Allergies = @Allergies WHERE PatientId = @PatientId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DoB", dob);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                command.Parameters.AddWithValue("@PatientContact", contact);
                command.Parameters.AddWithValue("@MedicalHistory", medicalHistory);
                command.Parameters.AddWithValue("@Allergies", allergies);
                command.Parameters.AddWithValue("@PatientId", patientId);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }
        public int DeletePatient(int patientId, string connectionString)
        {
            string query = "DELETE FROM PatientTbl WHERE PatientId = @PatientId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@PatientId", patientId);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

    }
}
