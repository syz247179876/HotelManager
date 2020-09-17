using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace 天秀酒店管理系统
{
    class mysql
    {
        public static string connstring=@"server=120.77.208.246;port=3306;User=demo;password=123456;Database=demo;";
        ///<summary>
        ///连接MySql数据库
        ///</summary>
        public MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            return conn;
        }
        ///<summary>
        ///执行Update,Delete,Insert操作
        ///</summary>
        /// <param name="sql"></param>
        public int ExecuteNonQuery(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result= cmd.ExecuteNonQuery();
            return result;
        }
        ///<summary>
        ///执行Update,Delete,Insert操作
        ///</summary>
        /// <param name="sql"></param>
        public object Executescalar(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if(cmd.ExecuteScalar()==null)
            {
                return false;
            }
            else 
            {
                return cmd.ExecuteScalar();
            }
        }
        ///<summary>
        ///执行read()操作
        ///</summary>
        /// <param name="sql"></param>
        public MySqlDataReader GetRead(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader da = cmd.ExecuteReader();
            return da;
        }
        ///<summary>
        ///填充适配器
        ///</summary>
        /// <param name="sql"></param>
        public DataSet GetDataSet(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static void ExeSql(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
            }
        }



    }
}
