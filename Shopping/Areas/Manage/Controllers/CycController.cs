﻿using Entities;
using IService;
using Newtonsoft.Json;
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
        IRoleGroupService RGroupService;
        IRoleContactService contactService;
        IUserinfoService userService;
        public CycController(IUserinfoService userService,IRoleService roleService, IRoleGroupService RGroupService,IRoleContactService contactService)
        {
            this.userService = userService;
            this.roleService = roleService;
            this.RGroupService = RGroupService;
            this.contactService = contactService;
        }



        #region 管理员权限


        #region 视图
        /// <summary>
        /// 管理员权限列表
        /// </summary>
        /// <returns></returns>
        public ActionResult RoleGroupList()
        {
            return View();
        }

        /// <summary>
        /// 管理员组编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult EditRoleGroup()
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

        #region 获取所有权限
        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoles() {
            return Json(roleService.GetRoles());
        }
        #endregion



        #region 管理权限组增删改
        #region 新增管理权限组
        /// <summary>
        /// 新增管理权限组
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertRoleGroup()
        {
            string name = Request["name"];
            List<int> roles = JsonConvert.DeserializeObject<List<int>>(Request["roles"]);


            if (!string.IsNullOrEmpty(name)) {
                return Content(RGroupService.InsertGroup(name,roles).ToString());
            }
            return Content("0");
        }
        #endregion
        #region 修改管理权限组
        public ActionResult UpdateRoleGroup() {

            //获取要修改的权限组编号
            int RGid = Convert.ToInt32(Request["RGid"]);
            //获取权限组名
            string name = Request["name"];
            //获取权限组所拥有的权限编号
            List<int> roles = JsonConvert.DeserializeObject<List<int>>(Request["roles"]);

            int i = RGroupService.UpdateRoleGroup(RGid,name,roles);
            return Content(i.ToString());
        }
        #endregion
        #region 删除管理权限组
        public ActionResult DeleteRoleGroups() {
            int gid = Convert.ToInt32(Request["RGid"]);
            int result = RGroupService.DeleteGroupByGid(gid);
            return Content(result.ToString());
        }
        #endregion
        #region 获取指定权限组及其所拥有的权限
        public ActionResult GetRoleInfo()
        {
            //获取权限组的编号
            int RGid = Convert.ToInt32(Request["RGid"]);
            //获取指定权限组
            RoleGroup RGroup = RGroupService.GetRoleGroup(RGid);
            //获取指定权限组下的所有权限
            IEnumerable<int> roleList = contactService.GetRidByGid(RGid);
            return Json(new { RGroup = RGroup, roleList = roleList });
        }
        #endregion
        #endregion


        #region 获取所有管理权限
        /// <summary>
        /// 获取所有管理权限组
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoleGroups()
        {
            return Json(RGroupService.GetRoleGroups());
        }
        #endregion
        #endregion


        #region 用户管理


        #region 视图
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public ActionResult UserList() {
            ViewData["Userinfos"] = JsonConvert.SerializeObject(userService.GetUsers(0,0,null,null,null,1,10));
            return View();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertUser()
        {
            //管理员组
            var RGroups = RGroupService.GetRoleGroups().ToList();
            RGroups.Add(new RoleGroup() { RG_no = 0, RG_name = "非管理员" });
            ViewData["infos"] = JsonConvert.SerializeObject(new { RGroups = RGroups });
            return View();
        }
        #endregion

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