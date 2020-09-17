using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天秀酒店管理系统.view
{
    public partial class alterpwd : Form
    {
        //旧密码
        public static string Password_old { get; set; }
        //新密码
        public static string Password_new { get; set; }
        //判断原密码是否正确，方便修改新密码
        public static bool Alter_success { get; set; }
        public alterpwd()
        {
            InitializeComponent();
          
        }

        private void alterpwd_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            timer1.Enabled = true;
            timer1.Interval = 1000;
            user.Text+= 天秀酒店管理系统.User;
            oldpwd.UseSystemPasswordChar = true;
            newpwd.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            oldpwd.UseSystemPasswordChar = false;
            button1.Text = "隐藏密码";
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            oldpwd.UseSystemPasswordChar = true;
            button1.Text = "显示密码";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
            newpwd.UseSystemPasswordChar = false;
            button2.Text = "隐藏密码";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            newpwd.UseSystemPasswordChar = true;
            button2.Text = "显示密码";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Password_old = MD5.Upper(oldpwd.Text.Trim());
            Password_new = MD5.Upper(newpwd.Text.Trim());
            try
            {
                mysql Mysql = new mysql();
                string sql = @"select password from users where user='" + 天秀酒店管理系统.User + "'";
                string result = Mysql.Executescalar(sql).ToString();
                if(result==Password_old)
                {
                    Alter_success = true;
                }
                else
                {
                    MessageBox.Show("原密码错误！请重新输入");
                    oldpwd.Text = "";
                    newpwd.Text = "";
                    Alter_success = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);     
            }
            finally
            {        
            }
            if(Alter_success==true)
            {
                try
                {
                    mysql Mysql = new mysql();
                    string sql = @"update users set password='" + Password_new + "' where user='" + 天秀酒店管理系统.User + "'";
                    int result_update = Mysql.ExecuteNonQuery(sql);
                    if (result_update != -1)
                    {
                        MessageBox.Show("修改成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oldpwd.Text = "";
            newpwd.Text = "";
        }
    }
}
