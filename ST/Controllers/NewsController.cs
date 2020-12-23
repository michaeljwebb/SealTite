using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ST.Models;

namespace ST.Controllers
{
    public class NewsController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /News/

        public ActionResult Index()
        {
            return View(db.News.ToList());
        }

        public ActionResult News()
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

        //
        // POST: /News/Create

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(News news, IEnumerable<HttpPostedFileBase> file)
        {
            if (ModelState.IsValid)
            {
                db.News.Add(news);
                db.SaveChanges();
                
                string physicalPath = HttpContext.Server.MapPath("../") + "UploadImagesNews" + "\\";

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var FileName = news.Id + ".jpg";
                    Request.Files[0].SaveAs(physicalPath + FileName);

                }

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
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(News news, IEnumerable<HttpPostedFileBase> file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(news).State = EntityState.Modified;
                db.SaveChanges();

                string physicalPath = HttpContext.Server.MapPath("~/") + "UploadImagesNews" + "\\";

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var FileName = news.Id + ".jpg";
                    Request.Files[0].SaveAs(physicalPath + FileName);

                }

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