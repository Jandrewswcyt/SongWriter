using Microsoft.EntityFrameworkCore;
using SongWriterApp.Core.Models;

namespace Repository
{
    public class SongWriterDbContext : DbContext 
    {
        public DbSet<Song> Songs { get; set; }

        public SongWriterDbContext(DbContextOptions<SongWriterDbContext> options) : base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./songs.db");
        }
    }
}