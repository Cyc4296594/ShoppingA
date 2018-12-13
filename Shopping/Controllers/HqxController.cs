using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class HqxController : Controller
    {
        // GET: Hqx
        public ActionResult Index()
        {
            return View();
        }

        //收货地址
        public ActionResult Address()
        {
            return View();
        }
    }
}