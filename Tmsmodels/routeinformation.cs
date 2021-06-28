using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class routeinformation
    {
        [Key]
        public int ID { get; set; }
       
        public int rootnumber { get; set; }
        public int vehiclenumber { get; set; }
        public string stops { get; set; }
        public routeinformation()
        { }
        public routeinformation(int Id, int rootno, int vehiclenum, string stp)
        {
            ID = Id;
            rootnumber = rootno;
            vehiclenumber = vehiclenum;
            stops = stp;
        }

    }
}

