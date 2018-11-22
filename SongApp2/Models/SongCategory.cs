using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongApp2.Models
{
    public class SongCategory
    {
        [Key]
        public long SongId { get; set; }
        public Song Song { get; set; }
        [Key]
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
