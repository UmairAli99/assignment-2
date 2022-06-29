using Microsoft.AspNetCore.Mvc;

namespace assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
