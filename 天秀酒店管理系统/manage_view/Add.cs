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
    public partial class Add : Form
    {   
        //姓名
        public static string Names { get; set; }
        //性别
        public static string Sex { get; set; }
        //出生日期
        public static string Birth { get; set; }
        //电话号码
        public static string Phone { get; set; }
        //岗位
        public static string Position { get; set; }
        //工作号
        public static string Number { get; set; }

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = imageList1.Images[0];
            Names = "";
            Sex = "";
            Birth = "";
            Phone = "";
            Position = "";
            Number = "";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            time.Enabled = false;
            time.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            Names = name.Text;
            Sex = sex.Text;
            Birth = birth.Text;
            Phone = phone.Text;
            Position = position.Text;
            Number = number.Text;
            mysql Mysql = new mysql();
            try
            {
                string sql = @"insert into staff(name,birth,sex,position,phone) values('" + Names + "','" + Birth + "','" + Sex + "','" + Position + "','" + Phone + "')";
                int result=Mysql.ExecuteNonQuery(sql);
                if (result != -1)
                {
                    MessageBox.Show("录入信息成功");
                }
                else
                {
                    MessageBox.Show("录入信息失败");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }
    }
}
