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
namespace 天秀酒店管理系统.survice_view
{
    public partial class RoomType : Form
    {
        public RoomType()
        {
            InitializeComponent();
        }
        public int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            time.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer2.Enabled = true;
            timer2.Interval = 2000;
            pictureBox1.Image = imageList1.Images[0];
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (i > imageList1.Images.Count - 1)
            {
                i = 0;
            }
            pictureBox1.Image = imageList1.Images[i];
            i++;
        }

        private void Display_Click(object sender, EventArgs e)
        {
            mysql Mysql = new mysql();
            try
            {
                string sql = @"select room_id,room_state,room_price,roomtype.roomtype_id,roomtype_name,room_area from roomtype,room where roomtype.roomtype_id=room.roomtype_id";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }
    }
}
