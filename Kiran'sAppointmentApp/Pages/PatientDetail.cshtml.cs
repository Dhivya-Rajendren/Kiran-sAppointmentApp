using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class PatientDetailModel : PageModel
    {
        public List<Patient> Patients { get; set; }

        public Patient _Patient { get; set; }

        public PatientDetailModel()
        {
            Patients = new List<Patient>()
            {
                new Patient(){PatientId=1,PatientName="James",Contact=7894561236,Email="James@gmail.com",PatientHistory="New Admission"},
                new Patient(){PatientId=2,PatientName="Rekha",Contact=7895561236,Email="Rekha@gmail.com",PatientHistory="Ortho CheckUp"},
                new Patient(){PatientId=3,PatientName="Prem",Contact=7832561236,Email="Prem@gmail.com",PatientHistory="Cardio Issues"}
            };
        }

        public void OnGet(int patientId)
        {
            _Patient = Patients.Find(p => p.PatientId == patientId);
        }
    }
}
