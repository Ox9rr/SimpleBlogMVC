using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlogMVC.Models;

namespace SimpleBlogMVC.DataBaseLogger
{
    public class DbLoggerModel
    {
        public int Id { get; set; }
        public string LogDescrption { get; set; }
        public DateTime DateLog { get; set; }
        public User userId;
    }
}
