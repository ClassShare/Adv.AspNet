using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class DBMohammadpour : DbContext
    {
        public DBMohammadpour()
        {
        }

        public DBMohammadpour(DbContextOptions<DBMohammadpour> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBMohammadpour;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Img).HasColumnType("image");

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
