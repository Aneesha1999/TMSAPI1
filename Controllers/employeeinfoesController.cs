using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;
using TMSAPI1.Data;

namespace TMSAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeinfoesController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public employeeinfoesController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/employeeinfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<employeeinfo>>> Getemployeeinfo()
        {
            return await _context.employeeinfo.ToListAsync();
        }

        // GET: api/employeeinfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<employeeinfo>> Getemployeeinfo(int id)
        {
            var employeeinfo = await _context.employeeinfo.FindAsync(id);

            if (employeeinfo == null)
            {
                return NotFound();
            }

            return employeeinfo;
        }

        // PUT: api/employeeinfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putemployeeinfo(int id, employeeinfo employeeinfo)
        {
            if (id != employeeinfo.employeeid)
            {
                return BadRequest();
            }

            _context.Entry(employeeinfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employeeinfoExists(id))
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

        // POST: api/employeeinfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<employeeinfo>> Postemployeeinfo(employeeinfo employeeinfo)
        {
            _context.employeeinfo.Add(employeeinfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getemployeeinfo", new { id = employeeinfo.employeeid }, employeeinfo);
        }

        // DELETE: api/employeeinfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteemployeeinfo(int id)
        {
            var employeeinfo = await _context.employeeinfo.FindAsync(id);
            if (employeeinfo == null)
            {
                return NotFound();
            }

            _context.employeeinfo.Remove(employeeinfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool employeeinfoExists(int id)
        {
            return _context.employeeinfo.Any(e => e.employeeid == id);
        }
    }
}
