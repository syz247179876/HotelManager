using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天秀酒店管理系统.survice_view
{
    public partial class StayInfo : Form
    {
        public StayInfo()
        {
            InitializeComponent();
        }

        private void StayInfo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            time.Enabled = false;
            mysql Mysql = new mysql();
            pictureBox1.Image = QR.QrCodeBitmap("www.baidu.com", 5, 3);
            try
            {
                string sql = @"select * from stayinfo";
                DataSet ds = Mysql.GetDataSet(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.AddSeconds(1).ToString();
        }
    }
}
