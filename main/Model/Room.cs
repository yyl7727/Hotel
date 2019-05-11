using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main.Model
{
    public class Room
    {
        /// <summary>
        /// 客房编号
        /// </summary>
        public string kfbh { get; set; }
        /// <summary>
        /// 客房类型
        /// </summary>
        public string kflx { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string zt { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string bz { get; set; }
    }
}
