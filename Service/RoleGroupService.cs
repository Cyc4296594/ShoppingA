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
        IRepository<RoleContact> contactRep;
        IRepository<Role> roleRep;
        public RoleGroupService(IUnitofWork unit) {
            this.unit = unit;
            RGroupRep = unit.Repository<RoleGroup>();
            contactRep = unit.Repository<RoleContact>();
            roleRep = unit.Repository<Role>();
        }

        /// <summary>
        /// 查询所有用户权限管理组
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleGroup> GetRoleGroups()
        {
            return RGroupRep.Get();
        }
        /// <summary>
        /// 查询权限组对应的权限信息
        /// </summary>
        /// <returns></returns>
        public decimal GetRoleInfo(int RGid) {
            var roleDB = roleRep.Get();
            var contactDB = contactRep.Get();

            //需要的数据
            //权限组对象
            var RGroup = RGroupRep.Get(x => x.RG_no == RGid, "", null).FirstOrDefault();
            //所关联的所有权限编号
            IEnumerable<int> list =  contactRep.Get(x => x.RG_no == RGid, "", null).Select(x => x.RC_no);




            //var obj = contactDB    .Join(roleDB, x => x.RG_no, y => y.R_no,(x, y) => new {
            //    x.RC_no,
            //    x.RG_no,
            //    x.R_no
            //}).Join(RGroupDB,x=>x.RG_no,y=>y.);
            return default(decimal);
        }
        /// <summary>
        /// 新增管理员组
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertGroup(string name,List<int> roles)
        {
            var RGroup= RGroupRep.Get(null, "", x => x.OrderByDescending(y => y.RG_no)).FirstOrDefault();
            int RGid = 1;
            if (RGroup != null) {
                RGid = RGroup.RG_no+1;
            }
            RGroupRep.Insert(new RoleGroup { RG_no = RGid, RG_name = name });
            foreach (var rid in roles)
            {
                contactRep.Insert(new RoleContact() { RG_no = RGid, R_no = rid });
            }
            return unit.Commit();
        }
    }
}
