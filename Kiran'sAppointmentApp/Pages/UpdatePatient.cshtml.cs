using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class UpdatePatientModel : PageModel
    {
        // AppointmentRepository repo = new AppointmentRepository();

        DBHelper repo = new DBHelper();
        [BindProperty]
        public Patient UpdatePatient { get; set; }
        public void OnGet(int patientId)
        {
            UpdatePatient = repo.GetPatient(patientId);
        }

        public IActionResult OnPost()
        {
            repo.EditPatient(UpdatePatient.PatientId, UpdatePatient.PatientHistory);
            return RedirectToPage("PatientsList");
        }
    }
}
