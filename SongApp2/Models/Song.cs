using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongApp2.Models
{
    public class Song
    {
        public long SongId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Link { get; set; }

        public IList<SongCategory> SongCategories { get; set; }
    }
}
