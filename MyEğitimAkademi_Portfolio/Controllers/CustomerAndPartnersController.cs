using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class CustomerAndPartnersController : Controller
    {
        // GET: CustomerAndPartners
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.CustomerAndPartners.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomerAndPartners()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomerAndPartners(CustomerAndPartners customerAndPartners)
        {
            db.CustomerAndPartners.Add(customerAndPartners);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomerAndPartners(int id)
        {
            var value = db.CustomerAndPartners.Find(id);
            db.CustomerAndPartners.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult UpdateCustomerAndPartners(int id)
        {
            var value = db.CustomerAndPartners.Find(id);
            return View(value);


        }
        [HttpPost]
        public ActionResult UpdateCustomerAndPartners(CustomerAndPartners customerAndPartners)
        {

            var value = db.CustomerAndPartners.Find(customerAndPartners.CustomerAndPartnersID);
            value.Title = customerAndPartners.Title;
            value.Description = customerAndPartners.Description;
            value.Image = customerAndPartners.Image;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}