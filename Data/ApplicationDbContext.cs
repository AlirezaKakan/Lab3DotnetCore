using System;
using Lab03.Models;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Lab03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Province>().ToTable("Province");
            modelBuilder.Entity<City>().ToTable("City");

            modelBuilder.Seed();
        }
        
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        
    }
}
