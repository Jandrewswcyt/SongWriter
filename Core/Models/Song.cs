using System;

namespace SongWriterApp.Core.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Text { get; set; }
    }
}