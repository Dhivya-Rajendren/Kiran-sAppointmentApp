using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class NewPatientModel : PageModel
    {
        AppointmentRepository repo = new AppointmentRepository();


        [BindProperty]
        public Patient NewPatient { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            repo.AddNewPatient(NewPatient);
            return RedirectToPage("PatientsList");
        }
    }
}
