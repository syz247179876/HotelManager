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
    public partial class Dismiss : Form
    {
        public Dismiss()
        {
            InitializeComponent();
        }

        private void Dismiss_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            timer1.Enabled = true;
            label4.Enabled = false;
            timer1.Interval = 1000;
            label4.Text = DateTime.Now.ToLocalTime().ToString();
            try
            {
                mysql Mysql = new mysql();
                MySqlConnection conn = Mysql.Connection();
                string sql = @"select * from staff";
                MySqlDataReader dr = Mysql.GetRead(sql);

                while (dr.Read())
                {

                    comboBox1.Items.Add(dr["name"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { }


        }

        private void delete_Click(object sender, EventArgs e)
        {
            mysql Mysql = new mysql();
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择要删除的员工");
            }
            else
            {
                try
                {     
                    string Name = comboBox1.SelectedItem.ToString();
                    string sql_delete = @"delete from staff where name='" + Name + "'";
                    int result = Mysql.ExecuteNonQuery(sql_delete);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    string sql = @"select * from staff";
                    DataSet ds = Mysql.GetDataSet(sql);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.AddSeconds(1).ToString();
        }
    }
}
