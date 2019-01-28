using System;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        //Add DbSets

        public DbSet<Patron> Patrons { get; set; }

    }
}
