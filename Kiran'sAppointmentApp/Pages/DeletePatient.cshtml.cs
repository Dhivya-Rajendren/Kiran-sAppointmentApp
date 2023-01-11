using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class DeletePatientModel : PageModel
    {
        AppointmentRepository repo = new AppointmentRepository();

        public Patient _Patient { get; set; }

        public void OnGet(int patientId)
        {
            _Patient = repo.GetPatient(patientId);
        }
    }
}
