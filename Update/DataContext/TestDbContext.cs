using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Update.Models;

namespace Update.DataContext
{
    public class TestDbContext: DbContext
    {
        public TestDbContext() : base("myTask") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Janr> Janrs { get; set; }
    }
}
