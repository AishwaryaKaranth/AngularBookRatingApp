using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AngularTrialApp.Models
{
    public class BookContext:DbContext
    {
        public BookContext() { }

        public DbSet<Book> Book { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        
    }
}
