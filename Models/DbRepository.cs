using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using SimpleBlogMVC.DataBaseLogger;

namespace SimpleBlogMVC.Models
{
    public interface IBlog
    {
        void CreatePost(Article article);
        Article EditPost(Article article);
        void DeletePost(int Id);
        //void DeactivatePost(int id);
        Article GetPost(string articleUrl);
        Article GetPostByID(int id);
        List<Article> GetArticles();
        List<Article> GetArticlesOnHomePage();
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
                DynamicParameters param = new DynamicParameters();
                //param.Add("@Id", article.Id);
                param.Add("@Title", article.Title);
                param.Add("@Description", article.Description);
                param.Add("@DateCreation", article.DateCreation);
                param.Add("@IsActive", article.IsActive);
                param.Add("@OnHomePage", article.OnHomePage);
                param.Add("@ArticleUrl", article.ArticleUrl);
                param.Add("@Content", article.Content);

                db.Execute("sp_CreatePost", param, commandType: CommandType.StoredProcedure);
                var dbLogger = new DbLogger(connectionString);
                dbLogger.CreateArticleLog(article);

                db.Close();
            }
        }

        public void DeletePost(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Articles WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }

        public Article EditPost(Article article)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                DynamicParameters param = new DynamicParameters();
                //param.Add("@Id", article.Id);
                param.Add("@Title", article.Title);
                param.Add("@Description", article.Description);
                param.Add("@DateCreation", article.DateCreation);
                param.Add("@IsActive", article.IsActive);
                param.Add("@OnHomePage", article.OnHomePage);
                param.Add("@ArticleUrl", article.ArticleUrl);
                param.Add("@Content", article.Content);

                db.Execute("sp_CreatePost", param, commandType: CommandType.StoredProcedure);

                db.Close();
                //return db.Query<Article>("Update Articles SET WHERE ID = @Id", new { id }).FirstOrDefault();
                return null;
            }
        }

        public List<Article> GetArticles()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                List<Article> testArticle = new List<Article>();
                testArticle.Add(new Article() { Title = "KekTitle" });
                try
                {
                    return db.Query<Article>("SELECT * FROM Articles").ToList();
                }
                catch (Exception ex)
                {
                    //return testArticle.Add(new Article() { Title = "KekTitle" });
                }
                //return testArticle;
                return db.Query<Article>("SELECT * FROM Articles").ToList();
            }
        }

        public Article GetPost(string articleUrl)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("SELECT * FROM Articles WHERE ArticleUrl = @articleUrl", new { articleUrl }).FirstOrDefault();
            }
        }

        public Article GetPostByID(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("SELECT * FROM Articles WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }

        public List<Article> GetArticlesOnHomePage()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("SELECT * FROM Articles WHERE OnHomePage=1").ToList();
            }
        }
    }
}
