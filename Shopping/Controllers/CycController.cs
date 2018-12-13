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
        [HttpGet]
        public ActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Information(object obj) {
            string to = Request["to"];
            switch (to)
            {
                case "GetInformation":
                    return GetInformation();
            }
            return View();
        }
        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <param name="context"></param>
        [HttpPost]
        private ActionResult GetInformation()
        {
            //用户名
            //会员
            //昵称
            //真实姓名
            //性别
            //身份证号码
            //出生日期
            //详细地址 省 市 区
            //个人简介
            return Json("");
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