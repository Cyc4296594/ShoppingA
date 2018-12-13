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
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<IocDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
