using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlogMVC.Models;

namespace SimpleBlogMVC.DataBaseLogger
{
    interface IDbLogger
    {
        public void CreateArticleLog(Article article);
        public void EditArticleLog(Article article);
        public void DeleteArticleLog(Article article);
    }
}
