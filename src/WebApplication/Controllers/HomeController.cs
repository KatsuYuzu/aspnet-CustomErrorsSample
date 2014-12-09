using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReturnStatus(int statusCode)
        {
            return new HttpStatusCodeResult(statusCode);
        }
    }
}