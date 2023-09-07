using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;
namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {

            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {
            var values = db.QuickContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {

            ViewBag.serviceTitle = db.Service.Select(x => x.ServiceTitle).FirstOrDefault();
            ViewBag.serviceComment = db.Service.Select(x => x.ServiceComment).FirstOrDefault();
            var values = db.Service.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();

            return PartialView(values);

        }
        public PartialViewResult PartialAward()
        {
            var value = db.Award.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialTestimonial()
        {
            ViewBag.description = db.Testimonial.Select(x => x.Description).FirstOrDefault();

            var values = db.Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult CustomerAndPartners()
        {
            ViewBag.totalProjectCount = db.Project.Count();
            var values = db.CustomerAndPartners.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {

            ViewBag.description = db.Adress.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.Phone).FirstOrDefault();
            ViewBag.adressDetail = db.Adress.Select(x => x.AddresDetail).FirstOrDefault();
            ViewBag.mail = db.Adress.Select(x => x.Mail).FirstOrDefault();
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return PartialView("Index", "Default");


        }



    }
}