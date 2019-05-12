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
        }

        private void Getroominfo()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
