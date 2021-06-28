using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class employeeinfo
    {
        [Key]

        public int employeeid { get; set; }
        
        public string name { get; set; }
      
        public int age { get; set; }
       
        public string location { get; set; }

       
        public string phoneno { get; set; }
      
        public int vehicleID { get; set; }

        public employeeinfo()
        { }

        public employeeinfo(int empid,string n,int a,string loc,string phone,int vid)
        {
            employeeid = empid;
            name = n;
            age = a;
            location = loc;
            phoneno = phone;
            vehicleID = vid;
        }

    }
}
