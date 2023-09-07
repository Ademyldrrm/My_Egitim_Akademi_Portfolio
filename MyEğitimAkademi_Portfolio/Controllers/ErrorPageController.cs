using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult Page404()
        {
            Response.StatusCode = 404;

            return View();
        }
        public ActionResult Page403()
        {
            Response.StatusCode = 403;

            return View();
        }
    }
}