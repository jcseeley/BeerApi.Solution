using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeerApi.Models;

namespace BeerApi.Controllers
{
    [Route("api/beers")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeerApiContext _context;

        public BeersController(BeerApiContext context)
        {
            _context = context;
        }

        // GET: api/Beers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beer>>> GetBeers(string style, string brewery, string name, double abv)
        {
            var query = _context.Beers.AsQueryable();
            if (style != null)
            {
              query = query.Where(entry => entry.Style == style);
            }
            if (name != null)
            {
              query = query.Where(entry => entry.Name.Contains(name));
            }
            if (brewery != null)
            {
              query = query.Where(entry => entry.Brewery == brewery);
            }
            if (abv > 0)
            {
              query = query.Where(entry => entry.Abv >= abv);
            }
            return await query.ToListAsync();
        }

        // GET: api/Beers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Beer>> GetBeer(int id)
        {
            var beer = await _context.Beers.FindAsync(id);

            if (beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        // PUT: api/Beers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBeer(int id, Beer beer)
        {
            if (id != beer.BeerId)
            {
                return BadRequest();
            }

            _context.Entry(beer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeerExists(id))
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

        // POST: api/Beers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Beer>> PostBeer(Beer beer)
        {
            _context.Beers.Add(beer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeer", new { id = beer.BeerId }, beer);
        }

        // DELETE: api/Beers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeer(int id)
        {
            var beer = await _context.Beers.FindAsync(id);
            if (beer == null)
            {
                return NotFound();
            }

            _context.Beers.Remove(beer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool BeerExists(int id)
        {
            return _context.Beers.Any(e => e.BeerId == id);
        }
    }
    [ApiVersion("2.0")]
    [Route("api/beers")]
    [ApiController]
    public class BeersV2Controller : ControllerBase
    {
        private readonly BeerApiContext _context;

        public BeersV2Controller(BeerApiContext context)
        {
            _context = context;
        }

        // GET: api/Beers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beer>>> GetBeers(string style, string brewery, string name, double abv)
        {
            var query = _context.Beers.AsQueryable();
            if (style != null)
            {
              query = query.Where(entry => entry.Style == style);
            }
            if (name != null)
            {
              query = query.Where(entry => entry.Name.Contains(name));
            }
            if (brewery != null)
            {
              query = query.Where(entry => entry.Brewery == brewery);
            }
            if (abv > 0)
            {
              query = query.Where(entry => entry.Abv >= abv);
            }
            return await query.ToListAsync();
        }

        // GET: api/Beers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Beer>> GetBeer(int id)
        {
            var beer = await _context.Beers.FindAsync(id);

            if (beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        // PUT: api/Beers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBeer(int id, Beer beer)
        {
            if (id != beer.BeerId)
            {
                return BadRequest();
            }

            _context.Entry(beer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeerExists(id))
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

        // POST: api/Beers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Beer>> PostBeer(Beer beer)
        {
            _context.Beers.Add(beer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeer", new { id = beer.BeerId }, beer);
        }

        // DELETE: api/Beers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeer(int id)
        {
            var beer = await _context.Beers.FindAsync(id);
            if (beer == null)
            {
                return NotFound();
            }

            _context.Beers.Remove(beer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
        [HttpGet("abv")]
        public async Task<ActionResult<IEnumerable<Beer>>> GetBeers()
        {
          return await _context.Beers.OrderByDescending(beer => beer.Abv).ToListAsync();
        }

        [HttpGet("random")]
        public async Task<ActionResult<Beer>> GetRandom()
        {
          Random rand = new Random();
          int id = rand.Next(1, _context.Beers.Count() + 1);
          return await _context.Beers.FindAsync(id);
        }
        private bool BeerExists(int id)
        {
            return _context.Beers.Any(e => e.BeerId == id);
        }
    }
}
