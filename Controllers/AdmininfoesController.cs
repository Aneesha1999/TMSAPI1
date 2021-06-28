using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;
using TMSAPI1.Data;
using TMSAPI1.Prod;

namespace TMSAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmininfoesController : ControllerBase
    {
        private readonly IAProvider _prod;

        public AdmininfoesController(IAProvider Prod)
        {
            _prod = Prod;
        }

        // GET: api/Admininfoes
        [HttpGet]
        public List<Admininfo> GetAdmininfo()
        {
            return _prod.GetAdmininfo();
        }

        // GET: api/Admininfoes/5
        [HttpGet("{id}")]
        public ActionResult<Admininfo> GetAdmininfo(int id)
        {


            return _prod.GetAdminfoById(id);
        }

        // PUT: api/Admininfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutAdmininfo(int id, Admininfo admininfo)
        {
           

            try
            {
                _prod.UpdateAdmininfo(id, admininfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_prod.AdmininfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Admininfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Admininfo> PostAdmininfo(Admininfo admininfo)
        {
            _prod.AddNewAdminfo(admininfo);


            return CreatedAtAction("GetAdmininfo", new { id = admininfo.AdminID }, admininfo);
        }

        // DELETE: api/Admininfoes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAdmininfo(int id)
        {
            _prod.DeleteAdmininfo(id);
            return NoContent();
        }

       
    }
}
