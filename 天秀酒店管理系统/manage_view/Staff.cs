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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = false;
            pictureBox1.Image = imageList1.Images[0];
            time.Text = DateTime.Now.ToLocalTime().ToString();
            try
            {
                mysql Mysql = new mysql();
                //MySqlConnection conn = Mysql.Connection();
                string sql = @"select * from staff";
                /*DataSet ds = Mysql.GetDataSet(sql);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";*/
                MySqlDataReader dr = Mysql.GetRead(sql);
               while(dr.Read())
                {
                    comboBox1.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常为：" + ex.Message);
            }
            finally
            {
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mysql Mysql = new mysql();
                MySqlConnection conn = Mysql.Connection();
                string sql = @"select * from staff";
                DataSet ds= Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show("异常为：" + ex.Message);  
            }
            finally
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string Name=comboBox1.SelectedItem.ToString();
            try
            {
                mysql Mysql = new mysql();
                MySqlConnection conn = Mysql.Connection();
                string sql = @"select * from staff where name='"+ Name + "'";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("异常为：" + ex.Message);
            }
            finally
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text=DateTime.Now.AddSeconds(1).ToString();
        }
    }
}
