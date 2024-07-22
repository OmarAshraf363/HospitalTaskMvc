using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTask01.Data;

namespace MvcTask01.Controllers
{
    public class AppointmentController : Controller
    {
        AppDbContext context=new AppDbContext();
        public IActionResult Index()
        {
            var All=context.Appointments.Include(e=>e.Doctor).ToList();
            return View(All);
        }
        public IActionResult Get(DateTime id)
        {
            var items = context.Appointments.Include(e=>e.Doctor).Where(e => e.Date ==id).ToList();
            return View("Index",items);
        }
    }
}
