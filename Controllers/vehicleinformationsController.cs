
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
    public class vehicleinformationsController : ControllerBase
    {
        private readonly TMSAPI1Context _context;

        public vehicleinformationsController(TMSAPI1Context context)
        {
            _context = context;
        }

        // GET: api/vehicleinformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<vehicleinformation>>> Getvehicleinformation()
        {
            return await _context.vehicleinformation.ToListAsync();
        }

        // GET: api/vehicleinformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<vehicleinformation>> Getvehicleinformation(int id)
        {
            var vehicleinformation = await _context.vehicleinformation.FindAsync(id);

            if (vehicleinformation == null)
            {
                return NotFound();
            }

            return vehicleinformation;
        }

        // PUT: api/vehicleinformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putvehicleinformation(int id, vehicleinformation vehicleinformation)
        {
            if (id != vehicleinformation.VehicleId)
            {
                return BadRequest();
            }

            _context.Entry(vehicleinformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!vehicleinformationExists(id))
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

        // POST: api/vehicleinformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<vehicleinformation>> Postvehicleinformation(vehicleinformation vehicleinformation)
        {
            _context.vehicleinformation.Add(vehicleinformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getvehicleinformation", new { id = vehicleinformation.VehicleId }, vehicleinformation);
        }

        // DELETE: api/vehicleinformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletevehicleinformation(int id)
        {
            var vehicleinformation = await _context.vehicleinformation.FindAsync(id);
            if (vehicleinformation == null)
            {
                return NotFound();
            }

            _context.vehicleinformation.Remove(vehicleinformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool vehicleinformationExists(int id)
        {
            return _context.vehicleinformation.Any(e => e.VehicleId == id);
        }
    }
}
