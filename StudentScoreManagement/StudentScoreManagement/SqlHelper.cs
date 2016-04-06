using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace StudentScoreManagement
{
    public class SqlHelper
    {
        private static string sqlStr = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        public static int Execute(string sql)
        {
            using (var conn = new SqlConnection(sqlStr))
            {
               return conn.Execute(sql);
            }
        }
        public static IEnumerable<T> Query<T>(string sql)
        {
            using (var conn = new SqlConnection(sqlStr))
            {
                return conn.Query<T>(sql);
            }
        }
    }
}