using MyEğitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);

        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {

            var value = db.Project.Find(id);
            db.Project.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.Project.Find(id);
            return View(value);
        }

        public ActionResult UpdateProject(Project project)
        {
            var value = db.Project.Find(project.ProjectID);
            value.Title = project.Title;
            value.ProjectCategory = project.ProjectCategory;
            value.Description = project.Description;
            value.CompleteDay = project.CompleteDay;
            value.Price = project.Price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}