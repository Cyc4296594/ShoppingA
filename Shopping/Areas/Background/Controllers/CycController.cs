using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Background.Controllers
{
    public class CycController : Controller
    {
        #region 新增用户
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertUser() {
            return View();
        }
        #endregion


        // GET: Background/Cyc
        public ActionResult Index()
        {
            return View();
        }
    }
}