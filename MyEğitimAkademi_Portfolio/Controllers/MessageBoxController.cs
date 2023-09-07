using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class MessageBoxController : Controller
    {
        // GET: MessagBox
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var value = db.Contact.ToList();
            return View(value);
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}