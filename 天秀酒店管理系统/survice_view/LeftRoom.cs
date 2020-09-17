using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
namespace 天秀酒店管理系统.survice_view
{
    public partial class LeftRoom : Form
    {
        public LeftRoom()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }

        private void LeftRoom_Load(object sender, EventArgs e)
        {
            mysql Mysql = new mysql();
            time.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            try
            {
                string sql = @"select * from room,roomtype where room.roomtype_id=room.roomtype_id and room_state='为空'";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
