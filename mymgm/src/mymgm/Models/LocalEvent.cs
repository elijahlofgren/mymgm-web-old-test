
using Microsoft.EntityFrameworkCore;
using System;

namespace mymgm.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LocalEvent
    {   public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }

    }

    public class LocalEventDBContext : DbContext
    {
        public LocalEventDBContext(DbContextOptions<LocalEventDBContext> options)
            : base(options)
        { }

        public DbSet<LocalEvent> LocalEvents { get; set; }
    }


}
