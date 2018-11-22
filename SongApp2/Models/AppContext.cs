using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongApp2.Models;

namespace SongApp2.Models 
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Song { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(bc => new { bc.SongId, bc.CategoryId });
            modelBuilder.Entity<SongCategory>()
                .HasOne(bc => bc.Song)
                .WithMany(b => b.SongCategories)
                .HasForeignKey(bc => bc.SongId);
            modelBuilder.Entity<SongCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.SongCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }
    }
}
