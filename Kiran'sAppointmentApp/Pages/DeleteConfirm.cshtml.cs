using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class DeleteConfirmModel : PageModel
    {
        AppointmentRepository repo = new AppointmentRepository();

        public IActionResult OnGet(int patientId)
        {
            repo.DeletePatient(patientId);

         return   RedirectToPage("PatientsList");

        }
    }
}
