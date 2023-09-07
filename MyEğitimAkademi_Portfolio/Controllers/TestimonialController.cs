using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {

            db.Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
            return View(value);

        }
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = db.Testimonial.Find(testimonial.TestimonialID);
            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.Comment = testimonial.Comment;
            value.ImageUrl = testimonial.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}