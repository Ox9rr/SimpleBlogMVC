﻿using System;
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
        Article EditPost();
        void DeletePost();
        void DeactivatePost(int id);
        Article GetPost(int id);
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
                var sqlQuery = ("INERT INTO Articles(Title, Description, DateCreation, IsActive, OnHomePage) VALUES" +
                    "@Title, @Description, @DateCreation, @IsActive, @OnHomePage");
                db.Execute(sqlQuery, article);
            }
        }

        public void DeactivatePost(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query<Article>("UPDATE Articles set IsActive = 0 WHERE ID = @Id", new { id }).FirstOrDefault();
            }
        }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public Article EditPost()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("Update * FROM Articles WHERE ID = @Id", new { id }).FirstOrDefault();
            }
        }

        public List<Article> GetArticles()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("SELECT * FROM Articles").ToList();
            }
        }

        public Article GetPost(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Article>("SELECT * FROM Articles WHERE ID = @Id", new { id }).FirstOrDefault(); 
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
