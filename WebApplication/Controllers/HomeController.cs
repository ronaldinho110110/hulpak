using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Name
        public ActionResult Index()
        {
            Model1 db = new Model1();
            List<RoleType> Names = new List<RoleType>();
            var cust =
                   (from c in db.RoleTypes
                    orderby c.Id
                    select c);
            
            foreach (var r in db.RoleTypes) 
            {
                Names.Add(r);
            }
            return View(Names);
        }
    }
}