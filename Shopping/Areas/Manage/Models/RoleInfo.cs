using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Areas.Manage.Models
{
    public class RoleInfo
    {
        public RoleInfo(RoleGroup RGroup, List<Role> Roles) {
            this.RGroup = RGroup;
            this.Roles = Roles;
        }

        /// <summary>
        /// 权限组
        /// </summary>
        public RoleGroup RGroup { get; }
        /// <summary>
        /// 所关联的权限集合
        /// </summary>
        public List<Role> Roles { get; }
    }
}