using System;

namespace EmotionsShopper.Controllers.Resources
{
    public class SongResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public string Text { get; set; }
    }
}