using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtectionTest.Models
{
    public partial class BookListRazorContext : DbContext
    {
        public BookListRazorContext()
        {
        }

        public BookListRazorContext(DbContextOptions<BookListRazorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.Name).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
