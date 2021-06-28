using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMSAPI.Models
{
    public class modify
    {
        [Key]
        public int Id { get; set; }
        public string employee { get; set; }
        public string vehicle { get; set; }
        
        public string routeinfo { get; set; }

        public modify ()
        { }

        public modify(int id, string emp,string vehc, string routeinf)
        {
            Id = id;
            employee = emp;
            vehicle = vehc;
            routeinfo = routeinf;
        }

    }
}

