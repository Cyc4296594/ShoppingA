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
    public class RoleContactService : IRoleContactService
    {
        IUnitofWork unit;
        IRepository<RoleContact> contactRep;

        public RoleContactService(IUnitofWork unit) {
            this.unit = unit;
            contactRep = unit.Repository<RoleContact>();
        }


        public IEnumerable<int> GetRidByGid(int gid)
        {
            throw new NotImplementedException();
        }
    }
}
