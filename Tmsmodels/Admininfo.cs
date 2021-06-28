using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class Admininfo
    {
        [Key]
        public int AdminID { get; set; }
       
       
        public string Username { get; set; }
       
        public String Password { get; set; }
        public Admininfo()
        { }
        public Admininfo(int admid, string uname, string pwd)
        {
            AdminID = admid;
            Username = uname;
            Password = pwd;
        }
    }
}
