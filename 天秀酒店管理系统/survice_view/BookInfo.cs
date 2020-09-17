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
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
          //  c1PictureBox1.Image = imageList1.Images[0];
            c1PictureBox1.BackgroundImage= imageList1.Images[0];
        }
    }
}
