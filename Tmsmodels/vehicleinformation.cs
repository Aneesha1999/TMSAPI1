using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class vehicleinformation
    {
        [Key]
        public int VehicleId { get; set; }
        public int vehiclenumber { get; set; }
        
        public int capacity { get; set; }
        
        public int seat { get; set; }
       
        public string operable { get; set; }
        public  vehicleinformation()
        { }
        public vehicleinformation(int vid, int vehicleno, int cty, int st, string op)

        {
            VehicleId = vid;
            vehiclenumber=vehicleno;
            capacity = cty;
            seat = st;
            operable = op;

        }

    }
}
