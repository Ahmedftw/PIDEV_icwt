using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options)
                                 : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.Property(e => e.Url).IsRequired();
            });
        }
        public virtual DbSet<Blogs> Blog { get; set; }
    }

}
