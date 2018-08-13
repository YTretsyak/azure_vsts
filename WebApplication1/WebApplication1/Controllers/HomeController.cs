using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  public class HomeController : Controller
  {
    private StudentContext db = new StudentContext();
    public ActionResult Index()
    {
      IEnumerable<Student> students = db.Students;
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    protected override void Dispose(bool disposing)
    {
      if (db != null)
      {
        db.Dispose();
        db = null;
      }
      base.Dispose(disposing);
    }
  }
}