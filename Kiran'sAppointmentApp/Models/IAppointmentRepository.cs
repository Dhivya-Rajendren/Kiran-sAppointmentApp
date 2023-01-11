namespace Kiran_sAppointmentApp.Models
{
    public interface IAppointmentRepository
    {

        // Declare the functionalities

        //CRUD of patient , Doctor,appointment


        List<Patient> GetAllPatients();
        Patient GetPatient(int id);

        void AddNewPatient(Patient patient);

        void DeletePatient(int patientId);

        void EditPatient(int patientId, string patientHistory);
    }
}
