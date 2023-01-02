using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class PatientsListModel : PageModel
    {
        public List<Patient> Patients { get; set; }

        public PatientsListModel()
        {
            Patients = new List<Patient>()
            {
                new Patient(){PatientId=1,PatientName="James",Contact=7894561236,Email="James@gmail.com",PatientHistory="New Admission"},
                new Patient(){PatientId=2,PatientName="Rekha",Contact=7895561236,Email="Rekha@gmail.com",PatientHistory="Ortho CheckUp"},
                new Patient(){PatientId=3,PatientName="Prem",Contact=7832561236,Email="Prem@gmail.com",PatientHistory="Cardio Issues"}
            };
        }
        public void OnGet()
        {
            ViewData["PageTitle"] = "List of Patients";
        }
    }
}
