using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
namespace 天秀酒店管理系统
{
    public static class MD5
    {
        /// <summary>
        /// 32位大写
        /// </summary>
        /// <returns></returns>
        public static string Upper(string pwd)
        {
            pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5").ToString();
            return pwd.ToUpper();
        }
        /// <summary>
        /// 32位小写
        /// </summary>
        /// <returns></returns>
        public static string Lower(string pwd)
        {
            pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5").ToString();
            return pwd.ToLower();
        }
    }
}
