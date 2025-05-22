using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcClient.Models;

namespace MvcClient.Data
{
    public class MvcClientContext : DbContext
    {
        public MvcClientContext (DbContextOptions<MvcClientContext> options)
            : base(options)
        {
        }

        public DbSet<MvcClient.Models.Customer> Customer { get; set; } = default!;
        public DbSet<MvcClient.Models.Supplier> Supplier { get; set; } = default!;
    }
}
