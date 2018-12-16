using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    /// <summary>
    /// 用户
    /// </summary>
    public interface IUserinfoService
    {
        IEnumerable<Userinfo> GetUsers(int grade, int roleGroup, string username, string email, string phone,int index,int size);
    }
}
