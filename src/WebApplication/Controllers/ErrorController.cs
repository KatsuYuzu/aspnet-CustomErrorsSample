using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string source, int statusCode)
        {
            ViewBag.Source = source;
            ViewBag.StatusCode = statusCode;

            return View();
        }
    }
}