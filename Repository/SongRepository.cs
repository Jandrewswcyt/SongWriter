using Repository;

namespace Repository
{
    public class SongRepository
    {
        private SongWriterDbContext context;
 
        public SongRepository(SongWriterDbContext ctx)
        {
            context = ctx; 
        }
    }
}