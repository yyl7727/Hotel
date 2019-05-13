using main.Bll;
using main.Model;
using main.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main.Frm.Rooms
{
    public partial class Roomsinfo : Form
    {
        Bll_room bll_room = new Bll_room();
        Order order = new Order();
        public string roomid;//获取传递来的房间号
        public Roomsinfo()
        {
            InitializeComponent();
        }

        private void Roomsinfo_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 页面信息初始化
        /// </summary>
        private void Init()
        {
            lb_roomid.Text = roomid;
            Getroominfo();
            lb_kflx.Text = order.kflx;
            lb_khxm.Text = order.khxm;
            lb_ldsj.Text = order.ldsj.ToShortDateString();
            lb_lxdh.Text = order.lxdh;
            lb_rksj.Text = order.rksj.ToString();
            lb_rzyj.Text = order.rzyj;
        }

        /// <summary>
        /// 根据页面传过来的房间id获取该订单信息
        /// </summary>
        private void Getroominfo()
        {
            //放弃使用datatable因为只用处理一个实体不需要转为list，直接使用Order接收信息即可
            //DatatableHelper.ConvertTo<Order>(bll_room.GetroominfoGetroominfowithkhbh(roomid));

            using (MySqlDataReader mydr = bll_room.GetroominfoGetroominfowithkhbh(roomid))
            {
                while (mydr.Read())
                {
                    order.lsh = mydr["lsh"].ToString();
                    order.ygxh = mydr["ygxh"].ToString();
                    order.kfbh = mydr["kfbh"].ToString();
                    order.kflx = mydr["kflx"].ToString();
                    order.khxm = mydr["khxm"].ToString();
                    order.xb = mydr["xb"].ToString();
                    order.csrq = Convert.ToDateTime(mydr["csrq"]);
                    order.sfzmhm = mydr["sfzmhm"].ToString();
                    order.lxdh = mydr["lxdh"].ToString();
                    order.rzyj = mydr["rzyj"].ToString();
                    order.rksj = Convert.ToDateTime(mydr["rksj"]);
                    order.ldsj = Convert.ToDateTime(mydr["ldsj"]);
                    order.zt = mydr["zt"].ToString();
                    order.bz = mydr["bz"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
