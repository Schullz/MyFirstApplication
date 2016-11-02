using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class CatsController : Controller
    {
        // GET: Cats
        public ActionResult Index()
        {
            var cats = new List<CatsViewModel>
            {
                new CatsViewModel
                {
                    Name = "Барсик",
                    FeetCount = 4,
                    IsLikeFish = true
                }
            };

            return View(cats);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}