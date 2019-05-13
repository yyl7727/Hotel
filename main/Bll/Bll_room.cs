using main.Dal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace main.Bll
{
    public class Bll_room
    {
        Dal_room dal = new Dal_room();
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public DataTable Getroomtype()
        {
            return dal.Getroomtype();
        }
        /// <summary>
        /// 根据房间类型获取房间
        /// </summary>
        /// <param name="fjlx"></param>
        /// <returns></returns>
        public DataTable Getroom(string fjlx)
        {
            return dal.Getroom(fjlx);
        }

        /// <summary>
        /// 根据客房编号获取订单信息
        /// </summary>
        /// <param name="kfbh"></param>
        /// <returns></returns>
        public MySqlDataReader GetroominfoGetroominfowithkhbh(string kfbh)
        {
            return dal.Getroominfowithkhbh(kfbh);
        }
    }
}
