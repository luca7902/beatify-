using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusikPlayer.Models;

namespace MusikPlayer.Data.Service
{
    public class BeatService
    {
        private readonly MusicDbContext _context;

        public BeatService(MusicDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<List<Beat>> GetAllBeatsAsync()
        {
            return await _context.Beats.ToListAsync();
        }
    }
}
