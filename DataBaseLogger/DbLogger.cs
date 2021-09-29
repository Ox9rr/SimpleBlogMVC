using SimpleBlogMVC.Models;
using System;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;
using System.Linq;

namespace SimpleBlogMVC.DataBaseLogger
{
    public class DbLogger : IDbLogger
    {
        string connectionString = null;

        public DbLogger(string conn)
        {
            connectionString = conn;
        }

        public void CreateArticleLog(Article article)
        {
            string messageDescription = "Created new Article by user: user with new id: " + article.Id;
            objLogger(messageDescription);
            LastArticleId(article);
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LogDescription", messageDescription);
                param.Add("@DateLog", DateTime.UtcNow);
                param.Add("@UserId", null);


                var sqlQuery = "INSERT INTO BlogLogs(LogDescrption, DateLog, UserId) Values(@LogDescription, @DateLog, @UserId)";
                db.Execute(sqlQuery, param);
            }
        }

        public void DeleteArticleLog(Article article)
        {
            throw new NotImplementedException();
        }

        public void EditArticleLog(Article article)
        {
            throw new NotImplementedException();
        }

        DbLoggerModel objLogger(string LogDescription)
        {
            return new DbLoggerModel
            {
                LogDescrption = LogDescription,
                DateLog = DateTime.Now,
                userId = null
            };
        }

        public Article LastArticleId(Article article)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var SomeObj = db.Query<Article>("SELECT IDENT_CURRENT('Articles')");
                var id = SomeObj.FirstOrDefault();
                return id;
            }
        }
    }
}
