using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace SimpleBlogMVC.Models
{
    public interface IBlog
    {
        void CreatePost(Article article);
        void EditPost();
        void DeletePost();
        void DeactivatePost();
        void GetPost();
        List<Article> GetArticles();
    }
    public class DbRepository : IBlog
    {
        string connectionString = null;

        public DbRepository(string conn)
        {
            connectionString = conn;
        }
        public void CreatePost(Article article)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = ("INERT INTO Articles(Title, Description, DateCreation, IsActive, OnHomePage) VALUES" +
                    "@Title, @Description, @DateCreation, @IsActive, @OnHomePage");
                db.Execute(sqlQuery, article);
            }
        }

        public void DeactivatePost()
        {
            throw new NotImplementedException();
        }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public void EditPost()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles()
        {
            throw new NotImplementedException();
        }

        public void GetPost()
        {
            throw new NotImplementedException();
        }
    }
}
