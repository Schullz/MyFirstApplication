using System.Linq;
using System.Web.Mvc;
using MyFirstApplication.DataAccess;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class CatsController : Controller
    {
        // GET: Cats
        public ActionResult Index()
        {
            using (var db = new PetDbContext())
            {
                var cats = db.Cats.ToList();

                return View(cats);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new CatModel());
        }

        [HttpPost]
        public ActionResult Create(CatModel model)
        {
            using (var db = new PetDbContext())
            {
                db.Cats.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var db = new PetDbContext())
            {
                var cat = db.Cats.FirstOrDefault(x => x.Id == id);

                return View(cat);
            }
        }

        [HttpPost]
        public ActionResult Edit(CatModel model)
        {
            using (var db = new PetDbContext())
            {
                var cat = db.Cats.FirstOrDefault(x => x.Id == model.Id);

                cat.FeetCount = model.FeetCount;
                cat.IsLikeFish = model.IsLikeFish;
                cat.Name = model.Name;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            using (var db = new PetDbContext())
            {
                var cat = db.Cats.FirstOrDefault(x => x.Id == id);

                return View(cat);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var db = new PetDbContext())
            {
                var cat = db.Cats.FirstOrDefault(x => x.Id == id);

                return View(cat);
            }
        }

        [HttpPost]
        public ActionResult Delete(CatModel model)
        {
            using (var db = new PetDbContext())
            {
                var cat = db.Cats.FirstOrDefault(x => x.Id == model.Id);

                db.Cats.Remove(cat);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}