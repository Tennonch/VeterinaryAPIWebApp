using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeterinaryAPIWebApp.Models;

namespace VeterinaryAPIWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitServicesController : ControllerBase
    {
        private readonly VeterinaryApiContext _context;

        public VisitServicesController(VeterinaryApiContext context)
        {
            _context = context;
        }

        // GET: api/VisitServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitService>>> GetVisitServices()
        {
            return await _context.VisitServices.ToListAsync();
        }

        // GET: api/VisitServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VisitService>> GetVisitService(int id)
        {
            var visitService = await _context.VisitServices.FindAsync(id);

            if (visitService == null)
            {
                return NotFound();
            }

            return visitService;
        }

        // PUT: api/VisitServices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitService(int id, VisitService visitService)
        {
            if (id != visitService.Id)
            {
                return BadRequest();
            }

            _context.Entry(visitService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitServiceExists(id))
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

        // POST: api/VisitServices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VisitService>> PostVisitService(VisitService visitService)
        {
            _context.VisitServices.Add(visitService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitService", new { id = visitService.Id }, visitService);
        }

        // DELETE: api/VisitServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitService(int id)
        {
            var visitService = await _context.VisitServices.FindAsync(id);
            if (visitService == null)
            {
                return NotFound();
            }

            _context.VisitServices.Remove(visitService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VisitServiceExists(int id)
        {
            return _context.VisitServices.Any(e => e.Id == id);
        }
    }
}
