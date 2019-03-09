using Poolearn.DataAccess;
using Poolearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poolearn.Controllers
{
    public class ThreadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            //if user not logged in go to create/register

            return View("Create");
        }

        //AUTHORIZE
        [HttpPost]
        public ActionResult Create(ThreadViewModel model)
        {
            bool success = false;

            if (!ModelState.IsValid)
                return View("Contact");



            using (var db = new PoolearnDbContext()) {
                db.Pools.Add(model);
                try {
                    success = true;
                    db.SaveChanges();
                }
                catch (Exception e) {
                    success = false;
                }
            }

            if (success) {
                //pass message into model

                //pass model into Session["user"]
                //display message on HttpGet Create()
                return View();
            }


            return View("Contact");
        }
    }
}