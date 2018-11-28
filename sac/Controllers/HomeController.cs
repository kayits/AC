using System.Web.Mvc;

namespace sac.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = User.Identity.IsAuthenticated;
            return View();
        }

        public ActionResult AnotherLink()
        {
            
            return View("Index");
        }
    }
}
