using Microsoft.AspNetCore.Mvc;
using MvcTask01.Data;
using MvcTask01.Models;

using System.Linq;

namespace MvcTask01.Controllers
{
    public class DoctorController : Controller
    {
      AppDbContext context=new AppDbContext();

        public IActionResult Index()
        {
            var doctors = context.Doctors.ToList();
            return View(doctors);
        }
        public IActionResult Show(int id)
        {
            var doctor = context.Doctors.Find(id);
            return View(doctor);  
        }
        [HttpPost]
        public IActionResult Add(Appointments appoint)
        {
            
                var appointment = new Appointments()
                {
                    Date = appoint.Date,
                    DoctorId = appoint.DoctorId,
                    PatientName = appoint.PatientName,
                    PatientPhone = appoint.PatientPhone,
                    Time = appoint.Time,
                    
                };
                context.Appointments.Add(appointment);
                context.SaveChanges();
                return View();
            
            
            

        }

      
    }
}
