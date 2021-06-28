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
    public class modifiesController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public modifiesController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/modifies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<modify>>> Getmodify()
        {
            return await _context.modify.ToListAsync();
        }

        // GET: api/modifies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<modify>> Getmodify(int id)
        {
            var modify = await _context.modify.FindAsync(id);

            if (modify == null)
            {
                return NotFound();
            }

            return modify;
        }

        // PUT: api/modifies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmodify(int id, modify modify)
        {
            if (id != modify.Id)
            {
                return BadRequest();
            }

            _context.Entry(modify).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!modifyExists(id))
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

        // POST: api/modifies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<modify>> Postmodify(modify modify)
        {
            _context.modify.Add(modify);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmodify", new { id = modify.Id }, modify);
        }

        // DELETE: api/modifies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletemodify(int id)
        {
            var modify = await _context.modify.FindAsync(id);
            if (modify == null)
            {
                return NotFound();
            }

            _context.modify.Remove(modify);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool modifyExists(int id)
        {
            return _context.modify.Any(e => e.Id == id);
        }
    }
}
