using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DependencyInjection.Controllers
{
   public interface IA
    {
        string nameA();

    }
   public interface IB
    {
        string nameB();
        int resB();
    }

  public interface IC
    {
        string nameC();
        int resC();

    }

    public class A : IA
    {
        private string Str;
        public A(string name)
        {
            Str = name;
        }
        public string str
        {
            get
            {
                return Str;
            }

        }
        public string nameA()
        {
            return this.Str;
        }
    }


    public class B : IB
    {
        IA _a;
        public B(IA a)
        {    // error ???
            _a = a;
        }
        public string nameB()
        {
            return this._a.nameA();
        }

        public int resB()
        {
            return 2;
        }
    }


    public class C : IC
    {
        IB _b;
        public C(IB b)
        {    //error ???
            _b = b;
        }
        public string nameC()
        {
            return this._b.nameB();
        }

        public int resC()
        {
            return 3;
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Unity()
        {
            IUnityContainer obj = new UnityContainer();
            obj.RegisterType<C>();
            obj.RegisterType<IA, A>();
            obj.RegisterType<IB, B>();
            C resC = obj.Resolve<C>();
            resC.nameC();
            return View(resC);
        }
        // GET: Home
       public ActionResult Index()
        {
            return View();
        }
    }
}