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
    public class routeinformationsController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public routeinformationsController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/routeinformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<routeinformation>>> Getrouteinformation()
        {
            return await _context.routeinformation.ToListAsync();
        }

        // GET: api/routeinformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<routeinformation>> Getrouteinformation(int id)
        {
            var routeinformation = await _context.routeinformation.FindAsync(id);

            if (routeinformation == null)
            {
                return NotFound();
            }

            return routeinformation;
        }

        // PUT: api/routeinformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putrouteinformation(int id, routeinformation routeinformation)
        {
            if (id != routeinformation.ID)
            {
                return BadRequest();
            }

            _context.Entry(routeinformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!routeinformationExists(id))
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

        // POST: api/routeinformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<routeinformation>> Postrouteinformation(routeinformation routeinformation)
        {
            _context.routeinformation.Add(routeinformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getrouteinformation", new { id = routeinformation.ID }, routeinformation);
        }

        // DELETE: api/routeinformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleterouteinformation(int id)
        {
            var routeinformation = await _context.routeinformation.FindAsync(id);
            if (routeinformation == null)
            {
                return NotFound();
            }

            _context.routeinformation.Remove(routeinformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool routeinformationExists(int id)
        {
            return _context.routeinformation.Any(e => e.ID == id);
        }
    }
}
