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
    public partial class Modify : Form
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
        //工作号=ID号
        public static int Number { get; set; }
        mysql Mysql = new mysql();
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            timer1.Enabled = true;
            label4.Enabled = false;
            timer1.Interval = 1000;
            label4.Text = DateTime.Now.ToLocalTime().ToString();
            try
            {
                string sql = @"select * from staff";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            //在datagridview中添加新的一列按钮控件
            DataGridViewButtonColumn modify = new DataGridViewButtonColumn
            {
                Name = "修改",
                HeaderText = "修改",
               
            };
            modify.DefaultCellStyle.NullValue = "修改";
            dataGridView1.Columns.Add(modify);

        }
        //单元格触发事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        //单元格触发事件
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            int rowindex = dataGridView1.CurrentCell.RowIndex; //得到行号
            int colindex = e.ColumnIndex;
            if (colindex == 6)
            {
                Names = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                Birth = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                Sex = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                Position = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                Phone = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                Number = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                try
                {
                    //修改员工基本信息
                    string sql = @"update staff set name='" + Names + "',birth='" + Birth + "',sex='" + Sex + "',position='" + Position + "',phone='" + Phone + "' where id=" + Number + "";
                    //修改员工工资表信息
                    int result = Mysql.ExecuteNonQuery(sql);
                    if (result != -1)
                    {
                        MessageBox.Show("修改成功！");

                    }
                    else
                    {
                        MessageBox.Show("修改失败!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { }
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.AddSeconds(1).ToString();
        }
    }
}
