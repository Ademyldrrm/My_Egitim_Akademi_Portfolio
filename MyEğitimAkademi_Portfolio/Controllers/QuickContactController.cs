using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class QuickContactController : Controller
    {
        // GET: QuickContact
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.QuickContact.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult QuickContactAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QuickContactAdd(QuickContact quickContact)
        {
            db.QuickContact.Add(quickContact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateQuickContact(int id)
        {
            var values = db.QuickContact.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateQuickContact(QuickContact quickContact)
        {
            var value = db.QuickContact.Find(quickContact.QuickContactID);
            value.NameSurname = quickContact.NameSurname;
            value.Description = quickContact.Description;
            value.Phone = quickContact.Phone;
            value.Mail = quickContact.Mail;
            value.Intagram = quickContact.Intagram;
            value.Lınkedın = quickContact.Lınkedın;
            value.Facebook = quickContact.Facebook;
            value.Twitter = quickContact.Twitter;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}