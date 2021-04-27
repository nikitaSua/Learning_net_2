using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Learning_net_2.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("Database1")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}