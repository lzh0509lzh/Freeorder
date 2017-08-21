using System;
using System.Configuration;
using System.Text;
using B1993.Core.DEncrypt;

namespace B1993.WebCommon
{
    
    public class ConfigB1993
    {

        private static readonly string strSQLServerIp = ConfigurationManager.AppSettings["strSQLServerIp"].ToString().Trim();
        private static readonly string strSQLDBUserName = ConfigurationManager.AppSettings["strSQLDBUserName"].ToString().Trim();
        private static readonly string strSQLDBPassword = ConfigurationManager.AppSettings["strSQLDBPassword"].ToString().Trim();
        private static readonly string strSQLDBName = ConfigurationManager.AppSettings["strSQLDBName"].ToString().Trim();
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnStringCenter
        {           
            get 
            {
                StringBuilder strConn = new StringBuilder();
                if (ConfigurationManager.AppSettings["ConStringEncrypt"] == "true")
                {
                    strConn.Append(DESEncrypt.Decrypt(strSQLServerIp));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBUserName));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBPassword));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBName));
                }
                return strConn.ToString();
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
