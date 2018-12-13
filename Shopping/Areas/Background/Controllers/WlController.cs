using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Background.Controllers
{
    public class WlController : Controller
    {
        // GET: Background/Wl
        public ActionResult Index()
        {
            return View();
        }
        //商品管理 添加商品
        public ActionResult add()
        {
            return View();
        }
    }
}