using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookAPI.Models
{
    public partial class BookDBContext : DbContext
    {
     

        public BookDBContext(DbContextOptions<BookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }


    }
}