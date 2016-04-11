﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using StudentScoreManagement.Models;

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

        public static IEnumerable<StudentScore> QueryStudentScore(long? scoreId)
        {
//            string sql = "select score.Id,score.Course,score.Score,stu.Name from StudentScore score inner join Student stu on score.StudentId=stu.Id";
            string sql = "select * from  StudentScore score left join Student stu on score.StudentId=stu.Id";
            if (scoreId != null)
            {
                sql += " where score.Id=" + scoreId;
            }
            using (var conn = new SqlConnection(sqlStr))
            {
                return conn.Query<StudentScore,Student, StudentScore>(sql, (score, student) =>
                {
                    score.Student = student;
                    return score;
                });
            }
        }

    }
}