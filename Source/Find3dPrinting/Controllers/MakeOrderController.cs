using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Find3dPrinting.Controllers
{
    public class MakeOrderController : Controller
    {
        //
        // GET: /MakeOrder/

        public ActionResult Step3_ChoosePrintProperties()
        {
            return View();
        }


        public ActionResult Step4_FindManufacturers()
        {
            return View();
        }

    }
}
