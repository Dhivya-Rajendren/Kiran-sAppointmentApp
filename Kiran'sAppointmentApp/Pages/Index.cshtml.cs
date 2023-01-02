using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kiran_sAppointmentApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<String> Doctors { get; set; }
        public void OnGet()
        {
            string pageSubTitle = "Home Page - Appointment Booking";

            //Data Dictionary 
            ViewData["SubTitle"] = pageSubTitle;

            Doctors = new List<string>();

            Doctors.Add("Kumar");
            Doctors.Add("Kiran");
            Doctors.Add("Abdul");
        }
    }
}