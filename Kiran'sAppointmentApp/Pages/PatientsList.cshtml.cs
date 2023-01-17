using Kiran_sAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class PatientsListModel : PageModel
    {
        public List<Patient> Patients { get; set; }

        //       AppointmentRepository repo = new AppointmentRepository();
         private readonly IConfiguration config;
      
        public PatientsListModel(IConfiguration config)
        {
            repo = new DBHelper();

        }

        DBHelper repo;
     


        /// <summary>
        /// Handles the incoming Get request
        /// </summary>
        public void OnGet()
        {
            Patients = repo.GetAllPatients();

            ViewData["PageTitle"] = "List of Patients";
        }
    }
}
