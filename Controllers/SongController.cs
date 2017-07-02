using Microsoft.AspNetCore.Mvc;
using Repository;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using EmotionsShopper.Controllers.Resources;
using Microsoft.EntityFrameworkCore;

namespace SongWriterApp.Controllers
{
    public class SongController : Controller
    {
        private readonly SongWriterDbContext context;
        private readonly IMapper mapper;
        public SongController(SongWriterDbContext ctx, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = ctx;

        }

        // public async Task<IEnumerable<SongResource>> GetSongs()
        // {
        //     var songs = await context.Songs.Include(s => s.Songs).ToListAsync(); 
        // }
    }
}