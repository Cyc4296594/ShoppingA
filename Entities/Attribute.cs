using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 属性列表
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int A_no { get; set; }
        /// <summary>
        /// 属性名称
        /// </summary>
        public string A_name { get; set; }
        /// <summary>
        /// 分组编号
        /// </summary>
        public int AG_no { get; set; }
        /// <summary>
        /// 展示类型(1文字 2单选框 3复选框)
        /// </summary>
        public int A_type { get; set; }
        /// <summary>
        /// 是否为筛选
        /// </summary>
        public int A_screen { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int A_order { get; set; }
    }
}
