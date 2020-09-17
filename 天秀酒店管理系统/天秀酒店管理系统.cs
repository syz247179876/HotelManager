using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using 天秀酒店管理系统.view;
using System.Web.Security;

namespace 天秀酒店管理系统
{
    public partial class 天秀酒店管理系统 : Form
    {
        //用户名
        public static string User { get; set; }
        //密码
        public static string Password { get; set; }
        //身份证号
        public static string Identity { get; set; }
        //性别
        public static string Sex { get; set; }
        //工作号
        public static int ID { get; set; }
        //电话号码
        public static string Phone { get; set; }
        //检查登录是否成功
        public static bool Login_pwd { get; set; }
        //检查登录是否成功
        public static bool Login_user { get; set; }
        //客服或者经理登录
        public static string person { get; set; }
        public void  Init()
        {
            User = UsertextBox.Text;
            Password = pwdtexbox.Text;
        }
        public void 天秀酒店管理系统_Load(object sender, EventArgs e)
        { 
            pwdtexbox.PasswordChar = '*';
            pwdtexbox.UseSystemPasswordChar = true;
            time.Text=DateTime.Now.ToLocalTime().ToString();
            time.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            //skinEngine1.SkinFile =@"D:\syz\天秀酒店管理系统\天秀酒店管理系统\皮肤\Diamond\DiamondBlue.ssk";
          //  skinEngine1.SkinFile = @"D:\syz\天秀酒店管理系统\天秀酒店管理系统\皮肤\Wave\WaveColor2.ssk";
            skinEngine1.SkinFile = @"D:\云中\天秀酒店管理系统\天秀酒店管理系统\皮肤\MP10\MP10.ssk";
        }


        public 天秀酒店管理系统()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"D:\云中\天秀酒店管理系统\天秀酒店管理系统\picture\11787e224d6f4fc50c6e35929d7c02a9.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;  //覆盖全屏不重复
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mysql Mysql = new mysql();
                if (service.Checked)
                {
                    person = service.Text;
                    if (UsertextBox.Text != "" && pwdtexbox.Text != "")
                    {
                        User = UsertextBox.Text;
                        Password = MD5.Upper(pwdtexbox.Text.Trim());
                        string sql_user = "select * from users where user='" + User + "' and position='"+person+"' and password='"+Password+"'";
                        MySqlDataReader da_user = Mysql.GetRead(sql_user);
                        if (da_user.Read())
                        {
                            Phone = da_user["phone"].ToString();
                            Sex = da_user["sex"].ToString();
                            ID = int.Parse(da_user["id"].ToString());
                            MessageBox.Show("欢迎" + User + person + "光临本系统！");
                            survice_view.survice_menu survice = new survice_view.survice_menu();
                            this.Hide();
                            survice.Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误！请重新输入");
                            pwdtexbox.Text = "";
                        }
                        da_user.Close();
                    }
                }
                else if(manage.Checked)
                {
                    person = manage.Text;
                    if (UsertextBox.Text != "" && pwdtexbox.Text != "")
                    {
                        User = UsertextBox.Text;
                        Password = MD5.Upper(pwdtexbox.Text.Trim());
                        string sql_user = "select user from users where user='" + User + "' and position='" + person + "' and password='" + Password + "'";
                        MySqlDataReader da_user = Mysql.GetRead(sql_user);
                        if (da_user.Read())
                        {
                            MessageBox.Show("欢迎" + User +person+ "光临本系统！");
                            view.Menu menu = new view.Menu();
                            this.Hide();
                            menu.Show();               
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误！请重新输入");
                            pwdtexbox.Text = "";
                        }
                        da_user.Close();
                    }
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("存在异常:" + ex);
            }
           


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString(); //时间自增1秒
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
