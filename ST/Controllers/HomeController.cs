﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ST.Models;

namespace ST.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /News/

        public ActionResult Index()
        {
            return View(db.News.ToList());
        }

        //
        // GET: /News/Details/5

        public ActionResult Details(int id = 0)
        {
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        //
        // GET: /News/Create

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult WhoWeAre()
        {
            return View();
        }

        public ActionResult ServicesOverview()
        {
            return View();
        }

        public ActionResult Testing()
        {
            return View();
        }

        public ActionResult Applications()
        {
            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult SealantDeliveryMethods()
        {
            return View();
        }

        public ActionResult CaseHistories()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult TechnicalPapers()
        {
            return View();
        }

        public ActionResult Troubleshooting()
        {
            return View();
        }

        public ActionResult safety()
        {
            return View();
        }

        public ActionResult MSDS()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Legal()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        //
        // POST: /News/Create

        [HttpPost]
        public ActionResult Create(News news)

        {
            if (ModelState.IsValid)
            {
                db.News.Add(news);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(news);
        }

        //
        // GET: /News/Edit/5

        public ActionResult Edit(int id = 0)
        {
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        //
        // POST: /News/Edit/5

        [HttpPost]
        public ActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                db.Entry(news).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(news);
        }

        //
        // GET: /News/Delete/5

        public ActionResult Delete(int id = 0)
        {
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        //
        // POST: /News/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            News news = db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}