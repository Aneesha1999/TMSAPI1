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
    public class userregistrationsController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public userregistrationsController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/userregistrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userregistration>>> Getuserregistration()
        {
            return await _context.userregistration.ToListAsync();
        }

        // GET: api/userregistrations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userregistration>> Getuserregistration(int id)
        {
            var userregistration = await _context.userregistration.FindAsync(id);

            if (userregistration == null)
            {
                return NotFound();
            }

            return userregistration;
        }

        // PUT: api/userregistrations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuserregistration(int id, userregistration userregistration)
        {
            if (id != userregistration.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userregistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userregistrationExists(id))
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

        // POST: api/userregistrations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<userregistration>> Postuserregistration(userregistration userregistration)
        {
            _context.userregistration.Add(userregistration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getuserregistration", new { id = userregistration.UserId }, userregistration);
        }

        // DELETE: api/userregistrations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuserregistration(int id)
        {
            var userregistration = await _context.userregistration.FindAsync(id);
            if (userregistration == null)
            {
                return NotFound();
            }

            _context.userregistration.Remove(userregistration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool userregistrationExists(int id)
        {
            return _context.userregistration.Any(e => e.UserId == id);
        }
    }
}
