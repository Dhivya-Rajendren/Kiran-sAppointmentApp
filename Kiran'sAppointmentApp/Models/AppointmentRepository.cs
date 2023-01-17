namespace Kiran_sAppointmentApp.Models
{
    public class AppointmentRepository : IAppointmentRepository
    {

    static    List<Patient> Patients = new List<Patient>()
            {
                new Patient(){PatientId=1,PatientName="James",Contact=7894561236,Email="James@gmail.com",PatientHistory="New Admission"},
                new Patient(){PatientId=2,PatientName="Rekha",Contact=7895561236,Email="Rekha@gmail.com",PatientHistory="Ortho CheckUp"},
                new Patient(){PatientId=3,PatientName="Prem",Contact=7832561236,Email="Prem@gmail.com",PatientHistory="Cardio Issues"}
            };

        public void AddNewPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void DeletePatient(int patientId)
        {
            Patients.Remove(Patients.Find(p=>p.PatientId==patientId));
        }

        public void EditPatient(int patientId, string patientHistory)
        {
            foreach (var item in Patients)
            {
                if (item.PatientId==patientId)
                {
                    item.PatientHistory = patientHistory;
                }
            }

        }

        public List<Patient> GetAllPatients()
        {
            return Patients;
        }

        public Patient GetPatient(int patientId)
        {
         return   Patients.Find(p => p.PatientId == patientId);
        }
    }
}
