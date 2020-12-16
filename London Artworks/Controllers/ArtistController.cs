using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("artist/{id}")]
        public async Task<ActionResult<Artist>> GetArtistById(int id)
        {
            var artist = await _context.Artists.Where(m => m.Id == id).FirstOrDefaultAsync();
            return artist;
        }

        [HttpPost("artist/create")]
        public async Task<ActionResult<Artist>> CreateArtist(Artist artist)
        {
            await _context.Artists.AddAsync(artist);
            _context.SaveChanges();
            return artist;
        }

        [HttpDelete("artist/delete/{id}")]
        public async Task<ActionResult<Artist>> DeleteArtist(int id)
        {
            var artist = await _context.Artists.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Artists.Remove(artist);
            _context.SaveChanges();
            return artist;
        }

        [HttpPut("artist/update/{id}")]
        public ActionResult<Artist> UpdateArtist(int id, Artist artist)
        {
            if (id != artist.Id)
            {
                return BadRequest();
            }
            var artistUpdate = _context.Artists.Attach(artist);
            artistUpdate.State = EntityState.Modified;
            _context.SaveChanges();
            return artist;
        }

        [HttpGet("artwork/all")]
        public async Task<ActionResult<IEnumerable<Artwork>>> GetAllArtwork()
        {
            var artwork = await _context.Artworks.OrderBy(m => m.Id).ToListAsync();
            return artwork;
        }

        [HttpGet("artwork/{id}")]
        public async Task<ActionResult<Artwork>> GetArtworkById(int id)
        {
            var artwork = await _context.Artworks.Where(m => m.Id == id).FirstOrDefaultAsync();
            return artwork;
        }

        [HttpGet("artwork/artist/{id}")]
        public async Task<ActionResult<IEnumerable<Artwork>>> GetArtistArtwork(int id)
        {
            var artwork = await _context.Artworks.OrderBy(m => m.Id).Where(m => m.ArtistId == id).ToListAsync();
            return artwork;
        }

        [HttpPost("artwork/create")]
        public async Task<ActionResult<Artwork>> CreateArtwork(Artwork artwork)
        {
            await _context.Artworks.AddAsync(artwork);
            _context.SaveChanges();
            return artwork;
        }

        [HttpDelete("artwork/delete/{id}")]
        public async Task<ActionResult<Artwork>> DeleteArtwork(int id)
        {
            var artwork = await _context.Artworks.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Artworks.Remove(artwork);
            _context.SaveChanges();
            return artwork;
        }

        [HttpPut("artwork/update/{id}")]
        public ActionResult<Artwork> UpdateArtwork(int id, Artwork artwork)
        {
            if(id != artwork.Id)
            {
                return BadRequest();
            }
            var artistUpdate = _context.Artworks.Attach(artwork);
            artistUpdate.State = EntityState.Modified;
            _context.SaveChanges();
            return artwork;
        }
    }
}
