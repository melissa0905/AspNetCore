using AspNetCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Contexts
{
    public class YoutubeContext:IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2V7PJIR; database=Deneme; User Id=ZGN; Password=123; trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
            .HasMany(p => p.Kategoriler)
            .WithOne(b => b.Urun);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet <Urun> Urunler { get; set; }
        public DbSet <Kategori> Kategoriler { get; set; }
        
    }
}
