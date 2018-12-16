using Core.UnitofWork;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoleContentService : IRoleContactService
    {
        IUnitofWork unit;
        public RoleContentService() {

        }

        public IEnumerable<int> GetRidByGid(int gid)
        {
            return null;
        }
    }
}
