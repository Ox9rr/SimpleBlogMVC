using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogMVC.Models
{
    public enum LvlManage
    {
        HighLvl = 1,
        MiddleLvl = 2,
        LowLvl =3
    }
    public class User
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public LvlManage LvlManage;
    }
}
