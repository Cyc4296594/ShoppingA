using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace Core.Mapping
{
    /// <summary>
    /// 数据库模型(用户)
    /// </summary>
    public class UserinfoMap : EntityTypeConfiguration<Userinfo>
    {
        public UserinfoMap()
        {
            //用户编号
            HasKey(x => x.U_no);
            //用户名
            Property(x => x.U_username).IsRequired();
            //密码
            Property(x => x.U_password).IsRequired();
            //是否是管理员
            Property(x => x.U_admin);
            //昵称
            Property(x => x.U_nick);
            //支付积分
            Property(x => x.U_ji);
            //用户头像
            Property(x => x.U_img);
            //用户手机号
            Property(x => x.U_tel);
            //用户邮箱
            Property(x => x.U_email);
            //注册时间
            Property(x => x.U_regtime);
            //最后一次登陆时间
            Property(x => x.U_logintime);
            //用户类型编号(外键)
            Property(x => x.UT_no).IsRequired();
            //默认地址(外键)
            Property(x => x.UA_no).IsRequired();
            //地区(外键)
            Property(x => x.C_no);
            
            //表名
            ToTable("Userinfo");
        }
    }
}
