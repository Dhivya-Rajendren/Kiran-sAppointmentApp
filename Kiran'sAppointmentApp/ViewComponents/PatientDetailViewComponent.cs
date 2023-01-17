using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kiran_sAppointmentApp.ViewComponents
{
    public class PatientDetailViewComponent:ViewComponent
    {
        DBHelper repo = new DBHelper();

        public IViewComponentResult Invoke(int patientID)
        {
            Patient patient = repo.GetPatient(patientID);
            return View(patient);
        }
    }
}
