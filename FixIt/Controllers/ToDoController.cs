using Microsoft.AspNetCore.Mvc;

namespace FixIt.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            //hömta todo items
            //skicka items till en modell
            //skicka resultatet till en view
            return View();
        }
    }
}
