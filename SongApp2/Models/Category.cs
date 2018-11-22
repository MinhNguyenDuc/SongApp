using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongApp2.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }

        public IList<SongCategory> SongCategories { get; set; }
    }
}
