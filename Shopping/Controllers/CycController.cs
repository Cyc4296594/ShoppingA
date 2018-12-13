using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class CycController : Controller
    {
        // GET: Cyc
        public ActionResult Index()
        {
            return View();
        }
        #region 个人信息
        public ActionResult Information()
        {
            return View();
        }
        #endregion

        #region 账号安全
        /// <summary>
        /// 账户安全
        /// </summary>
        /// <returns></returns>
        public ActionResult Safety() {
            return View();
        }
        #endregion
    }
}