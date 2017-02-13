using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models1;

namespace WebApplication.Controllers
{
    public class OutController : Controller
    {
       
        public ActionResult Index1()
        {
            Model2 db = new Model2();
            List<Players1> name = new List<Players1>();
            var cust =(from c in db.Players1
                   orderby c.Name
                   select c).First();

            foreach (var r in db.Players1)
            {
                name.Add(r);
            }
            return View(name);
        }
    }
}