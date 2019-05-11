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

namespace main.Frm
{
    public partial class Main : Form
    {
        Bll_room bll_room = new Bll_room();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Getroominfo();
        }

        /// <summary>
        /// 获取房间信息
        /// </summary>
        private void Getroominfo()
        {
            List<Roomtype> lst_roomtype = new List<Roomtype>();
            List<Room> lst_room = new List<Room>();
            // 获取房间类型
            lst_roomtype = (List<Roomtype>)DatatableHelper.ConvertTo<Roomtype>(bll_room.Getroomtype());
            for (int i = 0; i < lst_roomtype.Count; i++)
            {
                tab_roomtype.TabPages.Add(lst_roomtype[i].dmsm1);
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Name = "flp" + i;
                tab_roomtype.TabPages[i].Controls.Add(flp);
                //在这一个tab中添加此种类型的所有房间
                lst_room= (List<Room>)DatatableHelper.ConvertTo<Room>(bll_room.Getroom(lst_roomtype[i].dmz));
                for (int j = 0; j < lst_room.Count; j++)
                {
                    Button btn = new Button();
                    btn.Name = lst_room[j].kfbh;
                    btn.Image = Properties.Resources.room0;
                    btn.Height = 70;
                    btn.Width = 70;
                    btn.Text = lst_room[j].kfbh;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    flp.Controls.Add(btn);
                    btn.Click += new EventHandler(aBtn_Click);
                }
            }
        }

        private void aBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//获取被点击的控件,按钮  
            
        }
    }
}
