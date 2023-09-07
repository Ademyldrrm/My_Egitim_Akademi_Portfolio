using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        // GET: Contact
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.description = db.Adress.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.Phone).FirstOrDefault();
            ViewBag.adressDetail = db.Adress.Select(x => x.AddresDetail).FirstOrDefault();
            ViewBag.mail = db.Adress.Select(x => x.Mail).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public ActionResult PartialScript()
        {
            return PartialView();
        }
    }
}