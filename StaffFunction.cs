using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace HCPApp
{
    class StaffFunction
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;


        public StaffFunction()
        {
            Constr = @"Data Source=DESKTOP-KCIUG84\SQLEXPRESS;Initial Catalog=HCPAppDB;Integrated Security=True";
            Con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public void OpenConnection()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public void CloseConnection()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                cmd.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public void AddAppointment(int patientId, string patFName, string patLName, int doctorId, string docFName, string docLName, DateTime appointmentDate, int appointmentNumber, decimal charge)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO AppointmentTbl (PatientId, PatFName, PatLName, DoctorId, DocFName, DocLName, AppointmentDate, AppointmentNumber, Charge) " +
                               "VALUES (@PatientId, @PatFName, @PatLName, @DoctorId, @DocFName, @DocLName, @AppointmentDate, @AppointmentNumber, @Charge)";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@PatFName", patFName);
                cmd.Parameters.AddWithValue("@PatLName", patLName);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@DocFName", docFName);
                cmd.Parameters.AddWithValue("@DocLName", docLName);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                cmd.Parameters.AddWithValue("@AppointmentNumber", appointmentNumber);
                cmd.Parameters.AddWithValue("@Charge", charge);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
            }
        }

        public int GetNextAppointmentNumber()
        {
            try
            {
                OpenConnection();
                string query = "SELECT ISNULL(MAX(AppointmentNumber), 0) + 1 FROM AppointmentTbl";
                cmd.CommandText = query;
                int nextAppointmentNumber = (int)cmd.ExecuteScalar();
                return nextAppointmentNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}



