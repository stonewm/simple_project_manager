using System;
using MySql.Data.MySqlClient;

/*
 * 本模块的功能：
 * 1） 获取数据库连接
 * 2) 根据connection和select command text, 创建DataAdapter对象并返回
 */

namespace StoneUtils
{
    public class DbUtils
    {
        // 获取mysql数据库的连接
        public static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;user=root;database=dfm_ehr;port=3306;password=w123456;";
            var conn = new MySqlConnection(connStr);

            return conn;
        }

        // 创建DataAdapter对象并返回
        public static MySqlDataAdapter GetDataAdapter(String selCmdText, MySqlConnection connection)
        {
            var dataAdapter = new MySqlDataAdapter(selCmdText, connection);
            var sqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);

            return dataAdapter;
        }
    }
}
