using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace London_Artworks.Controllers
{
    [Route("londonartworks")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private IApplicationDbContext _context;

        public ArtistController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("artist/all")]
        public async Task<ActionResult<IEnumerable<Artist>>> GetAllArtists()
        {
            var artists = await _context.Artists.OrderBy(m => m.Id).ToListAsync();
            return artists;
        }

        [HttpPost("artist/create")]
        public async Task<ActionResult<Artist>> CreateArtist(Artist artist)
        {
            await _context.Artists.AddAsync(artist);
            _context.SaveChanges();
            return artist;
        }
    }
}
