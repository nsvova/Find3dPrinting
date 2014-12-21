using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Find3dPrinting.Models;
using Find3dPrinting.Data.DI;
using Find3dPrinting.Data.Interfaces;
using Ninject;

namespace Find3dPrinting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            /*Example how to work with Ninject*/
            /*
            IKernel kernel = new StandardKernel(new Find3dPrintingBinding());
            
            //Add new user
            kernel.Get<IRepository<User>>().Add(new User()
            {
                UsersId = 0,
                Email = "test@mail.com",
                Password = "123",
                PhoneNumber = "+123",
            });

            //Get all users
            IEnumerable<User> users = kernel.Get<IRepository<User>>().GetAll();

             * */

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
