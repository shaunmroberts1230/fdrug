using System.Web.Mvc;

namespace fdrug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Wow, look @ that...";

            return View();
        }
    }
}