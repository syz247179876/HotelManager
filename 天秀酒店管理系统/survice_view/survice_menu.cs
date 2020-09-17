using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace 天秀酒店管理系统.survice_view
{
    public partial class survice_menu : Form
    {
        public int i = 0;
        public survice_menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i>imageList1.Images.Count-1)
            {
                i = 0;
            }
            pictureBox1.Image = imageList1.Images[i];
            i++;
        }

        private void modify_survice_Load(object sender, EventArgs e)
        {
            string path = @"D:\云中\天秀酒店管理系统\天秀酒店管理系统\media\王笑文 - 耿耿于怀.wav";
            SoundPlayer bgm = new SoundPlayer(path);
            bgm.Play();
            pictureBox1.Image = imageList1.Images[0];
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer2.Enabled = true;
            timer2.Interval = 1000;
            time.Enabled = false;
            label2.Text = "欢迎" + 天秀酒店管理系统.User + "进入本系统!";
            name.Text = "姓名：  " + 天秀酒店管理系统.User;
            sex.Text = "性别：  " + 天秀酒店管理系统.Sex;
            phone.Text = "电话号码：  " + 天秀酒店管理系统.Phone;
            id.Text = "工作号：  " + 天秀酒店管理系统.ID.ToString();
            position.Text = "岗位：" + 天秀酒店管理系统.person;
            label6.Text = "我们的口号是：嘿嘿嘿酒店";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void 查看客房类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomType roomtype = new RoomType();
            roomtype.ShowDialog();
        }

        private void 查看剩余空房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeftRoom leftroom = new LeftRoom();
            leftroom.ShowDialog();
        }

        private void 餐饮服务_Click(object sender, EventArgs e)
        {
            Food_order food_order = new Food_order();
            food_order.ShowDialog();
        }

        private void 登记客人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StayInfo stayinfo = new StayInfo();
            stayinfo.ShowDialog();
        }

        private void 查看网上订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInfo bookinfo = new BookInfo();
            bookinfo.ShowDialog();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
