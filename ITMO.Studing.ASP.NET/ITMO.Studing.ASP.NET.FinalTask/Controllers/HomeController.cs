using ITMO.Studing.ASP.NET.FinalTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using static System.Web.Razor.Parser.SyntaxConstants;


namespace ITMO.Studing.ASP.NET.FinalTask
{
    public class HomeController : Controller
    {
        public StContext db = new StContext();
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InputStudentData()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InputStudentData(Student p)
        {
            try
            {
                db.Students.Add(p);
                db.SaveChanges();
                return View("InputStudentDataConf", p);
            }
            catch (Exception ex)
            {
                ViewBag.err = ex.ToString();
                return View("Error");
            }

        }

        /*public ViewResult OutputStudentData(string sortorder)
        {
            ViewBag.top5d=String.IsNullOrEmpty(sortorder) ? "" : "sorttop5d";
            ViewBag.top5a = String.IsNullOrEmpty(sortorder) ? "" : "sorttop5a";
            if (sortorder == "sorttop5d")
            {
                var qw = (from stud in db.Students
                         orderby stud.scoreSum descending
                         select stud).Take(5);
                ViewBag.stud = qw.ToList();
            }
            if (sortorder == "sorttop5a")
            {
                var qw = (from stud in db.Students
                          orderby stud.scoreSum
                          select stud).Take(5);
                ViewBag.stud = qw.ToList();
            }
            if (String.IsNullOrEmpty(sortorder))
                {
                var qw = from stud in db.Students
                          select stud;
                ViewBag.stud = qw.ToList();
            }
                var qw = from stud in db.Students
                         select stud;
                switch (sortorder)
                {
                    case "sorttop5d":
                        qw = (qw.OrderByDescending(stud => stud.scoreSum)).Take(5);
                        break;
                    case "sorttop5a":
                        qw = (qw.OrderBy(stud => stud.scoreSum)).Take(5);
                                   break;
                    default:
                        qw = qw.OrderByDescending(stud => stud.StudentId);
                        break;
                }
                
            return View("OutputStudentData");
        }*/
        [HttpGet]
        public ViewResult InputStudentPerfomanceData()
         {
            ViewData["allstud"]= from stud in db.Students
                                  select new SelectListItem {Text = stud.StudentId.ToString()+" "+ stud.FirstName.ToString()+" "+ stud.LastName.ToString(), Value = stud.StudentId.ToString() };
            return View();
        }
        [HttpPost]
        public ViewResult InputStudentPerfomanceData(StudentPerfomance s)
        {
            try
            {
                s.TestDate = DateTime.Now;                
                db.Students.Find(s.studentId).scoresum(s);
                db.StudentsPerfomance.Add(s);
                db.SaveChanges();
                ViewBag.st = db.Students.Find(s.studentId).ToString();
                return View("InputStudentPerfomanceDataConf", s);
            }
            catch (Exception ex)
            {
                ViewBag.err = ex.ToString();
                return View("Error");
            }
        }
        public ViewResult OutputStudentData()
        {
            ViewBag.stud = db.Students.ToList();
            return View("OutputStudentData");
        }
        public ViewResult OutputStudentDataTop5d()
        {
            var qw = (from stud in db.Students
                      orderby stud.scoreSum descending
                      select stud).Take(5);
            ViewBag.stud = qw.ToList();            
            return View("OutputStudentDataTop5d");
        }
        public ViewResult OutputStudentDataTop5a()
        {
            var qw = (from stud in db.Students
                      orderby stud.scoreSum
                      select stud).Take(5);
            ViewBag.stud = qw.ToList();
            return View("OutputStudentDataTop5a");
        }
        public ViewResult OutputStudentPerfomanceData()
        {
            // var query = from perf in db.StudentsPerfomance
            // join stud in db.Students on perf.studentId equals stud.StudentId
            //select new StudPerfInfo(perf.StudentPerfomanceId, perf.studentId, stud.FirstName, stud.LastName, perf.examName, perf.TestDate, perf.score );
            var allstudperf = db.StudentsPerfomance;
            ViewBag.Perf = allstudperf;
            return View("OutputStudentPerfomanceData");
        } 

    }
}