using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMSAPI.Models;
using TMSAPI1.Repository;

namespace TMSAPI1.Prod
{
    public class AdminProvider : IAProvider
    {

        private readonly IAdmin _repo;
        public AdminProvider(IAdmin repo)
        {
            _repo = repo;
        }

        public Admininfo AddNewAdminfo(Admininfo a)
        {
            _repo.AddNewAdminfo(a);
            return a;
        }

        public bool AdmininfoExists(int id)
        {

            _repo.AdmininfoExists(id);
            return true;
        }

        public void DeleteAdmininfo(int id)
        {
            _repo.DeleteAdmininfo(id);
        }

        public Admininfo GetAdminfoById(int id)
        {
            return _repo.GetAdminfoById(id);
        }

        public List<Admininfo> GetAdmininfo()
        {
            return _repo.GetAdmininfo();
        }

        public Admininfo UpdateAdmininfo(int id, Admininfo a)
        {
            _repo.UpdateAdmininfo(id, a);
            return a;
        }
    }
}
