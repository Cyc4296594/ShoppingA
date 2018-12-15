using Entities;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Manage.Controllers
{
    public class CycController : Controller
    {
        IRoleService roleService;
        public CycController(IRoleService roleService)
        {
            this.roleService = roleService;
        }


        #region 管理员权限
        /// <summary>
        /// 管理员权限列表
        /// </summary>
        /// <returns></returns>
        public ActionResult RoleList()
        {
            return View();
        }

        /// <summary>
        /// 获取所有管理权限组
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoles()
        {
            return Json(roleService.GetRoles().GroupBy(x => x.R_display));
        }
        /// <summary>
        /// 管理员组编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult EditRole()
        {
            //判断是新增还是修改
            object edit = Request["edit"];
            if (edit == null)
                return View(0);
            else
                //判断是否存在该管理组
                //不存在则返回回去
                return View(Convert.ToInt32(edit));
        }
        #endregion


        #region 新增用户
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertUser()
        {
            return View();
        }
        #endregion


        #region 我的积分
        public ActionResult MyIntegral()
        {
            return View();
        }
        #endregion

        #region 优惠券
        public ActionResult Discounts()
        {
            return View();
        }
        #endregion

        // GET: Manage/Cyc
        public ActionResult Index()
        {
            return View();
        }
    }
}