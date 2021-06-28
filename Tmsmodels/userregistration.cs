using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class userregistration
    {
        [Key]
        
       
        public int UserId { get; set; }
        public string User_firstname { get; set; }
      
        public string User_lastname { get; set; }
        public String Password { get; set; }
       
        public String CPassword { get; set; }

        public userregistration()
        {

        }
        public userregistration(int Uid, string userfirstname,string userlastname,string pwd
            ,string cpwd)
        {
            UserId = Uid;
           
            User_firstname = userfirstname;
            User_lastname = userlastname;
            Password = pwd;
            CPassword = cpwd;
        }


    }
}
