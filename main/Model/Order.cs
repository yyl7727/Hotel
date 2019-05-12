using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main.Model
{
    public class Order
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string lsh { get; set; }
        /// <summary>
        /// 员工序号
        /// </summary>
        public string ygxh { get; set; }
        /// <summary>
        /// 客房编号
        /// </summary>
        public string kfbh { get; set; }
        /// <summary>
        /// 客房类型
        /// </summary>
        public string kflx { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string khxm { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string xb { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime csrq { get; set; }
        /// <summary>
        /// 身份证明号码
        /// </summary>
        public string sfzmhm { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string lxdh { get; set; }
        /// <summary>
        /// 入住押金
        /// </summary>
        public string rzyj { get; set; }
        /// <summary>
        /// 入库时间（入住时间）
        /// </summary>
        public DateTime rksj { get; set; }
        /// <summary>
        /// 离店时间
        /// </summary>
        public DateTime ldsj { get; set; }
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
