using System.Data.SqlClient;

namespace Kiran_sAppointmentApp.Models
{
    public class DBHelper : IAppointmentRepository
    {

        //ADO .Net code
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public DBHelper()
        {
       
            con = new SqlConnection("Data Source=.;Initial Catalog=DoctorApponitmentDB;Integrated Security=True");
           
        }

        public void AddNewPatient(Patient patient)
        {
            //DML 

            con.Open();
            com = new SqlCommand("insert into patient values('" + patient.PatientName + "','" + patient.Email + "'," + patient.Contact + ",'" + patient.PatientHistory + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void DeletePatient(int patientId)
        {
            //DML -data manipulation language
            con.Open();
            com = new SqlCommand("Delete from patient where patientId=" + patientId, con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void EditPatient(int patientId, string patientHistory)
        {
            con.Open();
            com = new SqlCommand("update patient set patientHistory='" + patientHistory + "' where patientId = "+patientId, con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public List<Patient> GetAllPatients()
        {
            //DQL -Data Query language
            con.Open();
            com = new SqlCommand("Select * from patient", con);
            reader = com.ExecuteReader();
            List<Patient> patients = new List<Patient>();
            while(reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = reader.GetInt32(0);
                patient.PatientName = reader.GetString(1);
                patient.Email = reader.GetString(2);
                patient.Contact = reader.GetInt64(3);
                patient.PatientHistory = reader.GetString(4);
                patients.Add(patient);
            }
            reader.Close();
            con.Close();
            return patients;
        }

        public Patient GetPatient(int id)
        {
            return GetAllPatients().Find(p=>p.PatientId==id);
        }
    }
}
