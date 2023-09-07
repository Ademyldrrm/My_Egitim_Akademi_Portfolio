using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = db.Admin.FirstOrDefault(x => x.UserName == p.UserName && x.Pasword == p.Pasword);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["username"] = values.UserName.ToString();
                return RedirectToAction("Index", "Service");
            }
            return View();
        }
    }
}