using main.Dal;
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
        public DataTable Getroomtype()
        {
            return dal.Getroomtype();
        }

        public DataTable Getroom(string fjlx)
        {
            return dal.Getroom(fjlx);
        }

        public DataTable GetroominfoGetroominfowithkhbh(string kfbh)
        {
            return dal.Getroominfowithkhbh(kfbh);
        }
    }
}
