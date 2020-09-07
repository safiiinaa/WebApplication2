using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WA.Models
{
    public class WAContext : DbContext
    {
        public WAContext(DbContextOptions<WAContext> options)
            : base(options)
        {
        }

        public DbSet<WAItem> Items { get; set; }
    }
}
