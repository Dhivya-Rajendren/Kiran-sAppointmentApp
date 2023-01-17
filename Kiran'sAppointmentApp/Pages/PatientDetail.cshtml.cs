using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class PatientDetailModel : PageModel
    {
        //     AppointmentRepository repo = new AppointmentRepository();
        DBHelper repo = new DBHelper();

        public Patient _Patient { get; set; }

        public void OnGet(int patientId)
        {
            _Patient = repo.GetPatient(patientId);
        }
    }
}
