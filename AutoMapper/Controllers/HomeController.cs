using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapper.Controllers
{
              public class User1
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Number { get; set; }
    }

    public class User
    {
        public string FullName { get; set; }
        public int Number { get; set; }
    }

    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User1, User>()
                 .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + src.SurName)));

            User1 user = new User1()
            {
                FirstName = "Ivan",
                SurName = "Ivanov"
            };

            var newUser = Mapper.Map<User1, User>(user);
            return View(newUser);
        }
      }
    }
