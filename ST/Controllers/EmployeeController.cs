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
    public class EmployeeController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult OurPeople()
        {

            return View(db.Employees.ToList());
        }

        public ActionResult EmployeeUpload(string Id, HttpPostedFileBase image)
        {
            Employee employee = db.Employees.Find(Id);
            if (image != null)
            {
                employee.ImageType = image.ContentType;
                Int32 length = image.ContentLength;
                byte[] imageData = new byte[length];
                image.InputStream.Read(imageData, 0, length);
                employee.ActualImage = imageData;

                return View("../Employee/Create");
            }
            else
            {
                ViewBag.Error = "No image was selected";
                return View("../Employee/Create");
            }

        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Employee employee, IEnumerable<HttpPostedFileBase> file)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                string physicalPath = HttpContext.Server.MapPath("../") + "UploadImagesEmployee" + "\\";

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var FileName = employee.Id + ".jpg";
                    Request.Files[0].SaveAs(physicalPath + FileName);

                }

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Employee employee, IEnumerable<HttpPostedFileBase> file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                string physicalPath = HttpContext.Server.MapPath("~/") + "UploadImagesEmployee" + "\\";

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var FileName = employee.Id + ".jpg";
                    Request.Files[0].SaveAs(physicalPath + FileName);

                }

                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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