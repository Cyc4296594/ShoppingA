using Core.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    /// <summary>
    /// ef上下文
    /// </summary>
    public class IocDBContext:DbContext
    {
        public IocDBContext() : base("name=Shopping") {
            Database.SetInitializer(new IocInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //用户
            modelBuilder.Configurations.Add(new UserinfoMap());
            //用户类型
            modelBuilder.Configurations.Add(new UserTypeMap());
            //权限
            modelBuilder.Configurations.Add(new RoleMap());
            //管理权限组
            modelBuilder.Configurations.Add(new RoleGroupMap());
            //权限组对应
            modelBuilder.Configurations.Add(new RoleContactMap());
        }
    }
}
