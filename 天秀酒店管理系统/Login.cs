using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 天秀酒店管理系统;
namespace 天秀酒店管理系统.view
{
    class Login
    {
         //用户名
        public static string User { get; set; }
         //密码
        public static string Password { get; set; }
         //身份证号
        public static string ID { get; set; }
        //电话号码
        public static string Phone { get; set; }


        public static bool Init()
        {

                return true;
        }
    }


}
