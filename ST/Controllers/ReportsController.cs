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
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/

        public ActionResult chemicalInjectionMandrelTestingReport()
        {
            return View();
        }

        public ActionResult SubsurfaceSafetyValveTestingReport()
        {
            return View();
        }

        public ActionResult SubsurfaceSafetyValveTestingReportPetrobras()
        {
            return View();
        }

        public ActionResult UmbilicalLineTestingReport()
        {
            return View();
        }

        public ActionResult WellheadAndHangerTestingReport()
        {
            return View();
        }

        public ActionResult SubseaControlValveTestingReport()
        {
            return View();
        }

        public ActionResult SubseaSCSSVControlCircuitTestingReport()
        {
            return View();
        }

        public ActionResult FilterTestGlyFlo()
        {
            return View();
        }

        public ActionResult SpecializedTestGlyFlo()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
