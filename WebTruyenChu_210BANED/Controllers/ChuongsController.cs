using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTruyenChu_210BANED.Models;

namespace WebTruyenChu_210BANED.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongsController : ControllerBase
    {
        private readonly DataContext _context;

        public ChuongsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Chuongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chuong>>> GetChuongs()
        {
            return await _context.Chuongs.ToListAsync();
        }

        // GET: api/Chuongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chuong>> GetChuong(int id)
        {
            var chuong = await _context.Chuongs.FindAsync(id);

            if (chuong == null)
            {
                return NotFound();
            }

            return chuong;
        }

        // PUT: api/Chuongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChuong(int id, Chuong chuong)
        {
            if (id != chuong.maChuong)
            {
                return BadRequest();
            }

            _context.Entry(chuong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChuongExists(id))
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

        // POST: api/Chuongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Chuong>> PostChuong(Chuong chuong)
        {
            _context.Chuongs.Add(chuong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChuong", new { id = chuong.maChuong }, chuong);
        }

        // DELETE: api/Chuongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChuong(int id)
        {
            var chuong = await _context.Chuongs.FindAsync(id);
            if (chuong == null)
            {
                return NotFound();
            }

            _context.Chuongs.Remove(chuong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChuongExists(int id)
        {
            return _context.Chuongs.Any(e => e.maChuong == id);
        }
    }
}
