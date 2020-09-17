using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Media;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;
namespace 天秀酒店管理系统.view
{
    public partial class Menu : Form
    {
        public static string Address { get; set; }
        int i = 0;
        public Menu()
        {
            InitializeComponent();
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (i > imageList1.Images.Count-1)
            {
                i = 0;
            }
            pictureBox1.Image = imageList1.Images[i];
            pictureBox1.Refresh();
            i++;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string path = @"D:\云中\天秀酒店管理系统\天秀酒店管理系统\media\王笑文 - 耿耿于怀.wav";
            SoundPlayer bgm = new SoundPlayer(path);
            bgm.Play();
            pictureBox1.Image = imageList1.Images[0];
            //this.BackgroundImage = Image.FromFile(@"D:\天秀酒店管理系统\天秀酒店管理系统\天秀酒店管理系统\picture\timg2.jpg");
            timer1.Enabled = true;
            timer1.Interval = 1500;
            time.Text = DateTime.Now.ToLocalTime().ToString();
            timer2.Enabled = true;
            timer2.Interval = 1000;
            time.Enabled = false;
            linkLabel1.Text.Substring(5, linkLabel1.Text.Length-5);
            Address=(linkLabel1.Text.Substring(5, linkLabel1.Text.Length - 5));
            pictureBox2.Image = QR.QrCodeBitmap(Address, 5, 2);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IEXPLORE.EXE", "http://www.dota2.com");
        }

        private void 首页显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void 查看员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void 修改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.ShowDialog();
        }

        private void 解雇员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dismiss dismiss = new Dismiss();
            dismiss.ShowDialog();
        }

        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterpwd Alterpwd = new alterpwd();
            Alterpwd.ShowDialog();
        }

        private void 分发员工工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distribute_pay distribute_Pay = new Distribute_pay();
            distribute_Pay.ShowDialog();
        }
    }
}
