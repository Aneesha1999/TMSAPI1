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
    public class allocatevehiclesController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public allocatevehiclesController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/allocatevehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<allocatevehicle>>> Getallocatevehicle()
        {
            return await _context.allocatevehicle.ToListAsync();
        }

        // GET: api/allocatevehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<allocatevehicle>> Getallocatevehicle(int id)
        {
            var allocatevehicle = await _context.allocatevehicle.FindAsync(id);

            if (allocatevehicle == null)
            {
                return NotFound();
            }

            return allocatevehicle;
        }

        // PUT: api/allocatevehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putallocatevehicle(int id, allocatevehicle allocatevehicle)
        {
            if (id != allocatevehicle.ID)
            {
                return BadRequest();
            }

            _context.Entry(allocatevehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!allocatevehicleExists(id))
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

        // POST: api/allocatevehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<allocatevehicle>> Postallocatevehicle(allocatevehicle allocatevehicle)
        {
            _context.allocatevehicle.Add(allocatevehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getallocatevehicle", new { id = allocatevehicle.ID }, allocatevehicle);
        }

        // DELETE: api/allocatevehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteallocatevehicle(int id)
        {
            var allocatevehicle = await _context.allocatevehicle.FindAsync(id);
            if (allocatevehicle == null)
            {
                return NotFound();
            }

            _context.allocatevehicle.Remove(allocatevehicle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool allocatevehicleExists(int id)
        {
            return _context.allocatevehicle.Any(e => e.ID == id);
        }
    }
}
