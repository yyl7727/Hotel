using main.Model;
using main.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace main.Dal
{
    public class Dal_room
    {
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public DataTable Getroomtype()
        {
            return SQLHelper.GetDataSet("Getroomtype", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// 获取某一房间类型的所有房间列表
        /// </summary>
        /// <param name="fjlx"></param>
        /// <returns></returns>
        public DataTable Getroom(string fjlx)
        {
            MySqlParameter[] parameters = {
                   new MySqlParameter("@lx",fjlx)
                                         };
            return SQLHelper.GetDataSet("Getroomlist", CommandType.StoredProcedure, parameters);
        }
        /// <summary>
        /// 通过房间编号获取房间信息
        /// </summary>
        /// <param name="kfbh"></param>
        /// <returns></returns>
        public MySqlDataReader Getroominfowithkhbh(string kfbh)
        {
            MySqlParameter[] parameters = {
                   new MySqlParameter("@roomid",kfbh)
                                         };
            return SQLHelper.ExecuteReader("Getroominfo", CommandType.StoredProcedure, parameters);
        }
    }
}
