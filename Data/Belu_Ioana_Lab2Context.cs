using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Belu_Ioana_Lab2.Models;

namespace Belu_Ioana_Lab2.Data
{
    public class Belu_Ioana_Lab2Context : DbContext
    {
        public Belu_Ioana_Lab2Context (DbContextOptions<Belu_Ioana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Belu_Ioana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Belu_Ioana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Belu_Ioana_Lab2.Models.Author> Author { get; set; }
    }
}
