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
        public DataTable Getroom(string fjlx)
        {
            MySqlParameter[] parameters = {
                   new MySqlParameter("@lx",fjlx)
                                         };
            return SQLHelper.GetDataSet("Getroom", CommandType.StoredProcedure, parameters);
        }
    }
}
