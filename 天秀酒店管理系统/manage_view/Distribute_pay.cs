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

namespace 天秀酒店管理系统.view
{
    public partial class Distribute_pay : Form
    {
        //规定每天的工资
        public static int daysalary = 2000;
        //获取或设置每个月的工资
        public static int Monthsalary { get; set; }
        //规定read（）循环的下标
        public static int i = 0;
        
        public Distribute_pay()
        {
            InitializeComponent();
        }

        private void Distribute_pay_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            timer1.Enabled = true;
            timer1.Interval = 1000;
            time.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysql Mysql = new mysql();
            try
            {
                string sql = @"select id,name,position,rest_holiday,salary from pay";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            mysql Mysql = new mysql();
            int[] arr_ID = new int[3000];          //假设最大值为3000人
            try
            {
                string sql_id = @"select * from pay"; //依照工作号筛选每个人，通过这个给每个人依次分配工资
                MySqlDataReader dr = Mysql.GetRead(sql_id);
                while(dr.Read())
                {
                    arr_ID[i] = int.Parse(dr["id"].ToString());
                    string sql_rest = @"select rest_holiday from pay where id=" + arr_ID[i] + "";
                    int restday = int.Parse(Mysql.Executescalar(sql_rest).ToString());
                    if (Mysql.Executescalar(sql_rest) != null)
                    {
                        Monthsalary = daysalary * (30-restday);
                    }
                    string sql_total = @"update pay set salary=" + Monthsalary + " where id=" + arr_ID[i] + " ";
                    int result = Mysql.ExecuteNonQuery(sql_total);        
                    i++;
                }
                if (i != -1)
                {
                    MessageBox.Show("分配工资成功!");
                }
                else
                {
                    MessageBox.Show("分配工资失败！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }
    }
}
