using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class login
    {
        [Key]
        public int UserID { get; set; }
        
        public string username { get; set; }
        
        public string password { get; set; }

        public login()
        { }
        public login( int uid,string uname,string pwd)
        {
            UserID = uid;
            username = uname;
            password = pwd;
        }
    }
}
