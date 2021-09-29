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
        public string Description { get; set; }
        DateTime DateLog { get; set; }
        public User user;
    }
}
