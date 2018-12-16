using Core.Repository;
using Core.UnitofWork;
using Entities;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoleGroupService : IRoleGroupService
    {
        IUnitofWork unit;
        IRepository<RoleGroup> RGroupRep;
        IRepository<Role> roleRep;
        public RoleGroupService(IUnitofWork unit) {
            this.unit = unit;
            RGroupRep = unit.Repository<RoleGroup>();
            roleRep = unit.Repository<Role>();
        }s

        /// <summary>
        /// 查询所有用户权限管理组
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleGroup> GetRoleGroups()
        {
            return RGroupRep.Get();
        }
        /// <summary>
        /// 新增管理员组
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertGroup(string name,List<int> roles)
        {
            RGroupRep.Insert(new RoleGroup { RG_name = name });
            return unit.Commit();
        }
    }
}
