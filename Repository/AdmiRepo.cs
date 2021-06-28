using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMSAPI.Models;
using TMSAPI1.Data;

namespace TMSAPI1.Repository
{
    public class AdmiRepo : IAdmin
    {
        private readonly TMSAPI1Context _context;
        public AdmiRepo(TMSAPI1Context Context)
        {
            _context = Context;
        }
        public Admininfo AddNewAdminfo(Admininfo a)
        {
            _context.Admininfo.Add(a);
            _context.SaveChanges();
            return a;
        }

        public bool AdmininfoExists(int id)
        {
            return _context.Admininfo.Any(e => e.AdminID == id);

        }

        public void DeleteAdmininfo(int id)
        {
            Admininfo a = _context.Admininfo.Find(id);
            _context.Admininfo.Remove(a);
            _context.SaveChanges();
        }

        public Admininfo GetAdminfoById(int id)
        {
            return (_context.Admininfo.Find(id));
        }

        public List<Admininfo> GetAdmininfo()
        {
            return _context.Admininfo.ToList();
        }

        public Admininfo UpdateAdmininfo(int id, Admininfo a)
        {
            _context.Update(a);
            _context.SaveChanges();
            return a;
        }
    }


}

