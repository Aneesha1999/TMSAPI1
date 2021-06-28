using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;

namespace TMSAPI1.Data
{
    public class TMSAPI1Context : DbContext
    {
        public TMSAPI1Context (DbContextOptions<TMSAPI1Context> options)
            : base(options)
        {
        }

        public DbSet<TMSAPI.Models.Admininfo> Admininfo { get; set; }

        public DbSet<TMSAPI.Models.allocatevehicle> allocatevehicle { get; set; }

        public DbSet<TMSAPI.Models.employeeinfo> employeeinfo { get; set; }

        public DbSet<TMSAPI.Models.login> login { get; set; }

        public DbSet<TMSAPI.Models.modify> modify { get; set; }

        public DbSet<TMSAPI.Models.routeinformation> routeinformation { get; set; }

        public DbSet<TMSAPI.Models.userregistration> userregistration { get; set; }

        public DbSet<TMSAPI.Models.vehicleinformation> vehicleinformation { get; set; }
    }
}
