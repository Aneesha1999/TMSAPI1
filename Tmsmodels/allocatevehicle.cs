using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class allocatevehicle
    {
        [Key]
        public int ID { get; set; }
        public string vehicleallocationtopassenger { get; set; }

        public allocatevehicle()
        { }
        public allocatevehicle(int id,string vehiclelocpass)
        {
            ID = id;
            vehicleallocationtopassenger = vehiclelocpass;
        }
    }
}
