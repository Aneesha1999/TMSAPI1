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
    public class loginsController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public loginsController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/logins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<login>>> Getlogin()
        {
            return await _context.login.ToListAsync();
        }

        // GET: api/logins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<login>> Getlogin(int id)
        {
            var login = await _context.login.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }

        // PUT: api/logins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putlogin(int id, login login)
        {
            if (id != login.UserID)
            {
                return BadRequest();
            }

            _context.Entry(login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!loginExists(id))
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

        // POST: api/logins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<login>> Postlogin(login login)
        {
            _context.login.Add(login);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getlogin", new { id = login.UserID }, login);
        }

        // DELETE: api/logins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletelogin(int id)
        {
            var login = await _context.login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _context.login.Remove(login);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool loginExists(int id)
        {
            return _context.login.Any(e => e.UserID == id);
        }
    }
}
