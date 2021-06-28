using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMSAPI.Models;

namespace TMSAPI1.Prod
{
   public interface IAProvider
    {
        public List<Admininfo> GetAdmininfo();
        public Admininfo GetAdminfoById(int id);
        public Admininfo AddNewAdminfo(Admininfo a);
        public void DeleteAdmininfo(int id);
        public Admininfo UpdateAdmininfo(int id, Admininfo a);
        public bool AdmininfoExists(int id);

    }
}
