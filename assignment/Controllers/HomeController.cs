using Microsoft.AspNetCore.Mvc;

namespace assignment.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index(string fname,string lname,string phone,string mail,string gender,string dept)
        {
            if(fname=="Umair" && lname == "Ali" && phone == "+923082289363" && mail == "19101001-115@uskt.edu.pk" &&
                gender == "male" || gender == "female" && dept == "sales" || dept == "it" )
            {
                ViewBag.result = "Data submitted Successfully...";
            }
            else
            {
                ViewBag.result = "Please Enter right data...";
            }
            return View();
        }
    }
}
