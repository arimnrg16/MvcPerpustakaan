using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPerpustakaan.Models
{
    public class MvcPerpustakaanContext : DbContext
    {
        public MvcPerpustakaanContext(DbContextOptions<MvcPerpustakaanContext> options)
            : base(options)
        {
        }
        public DbSet<MvcPerpustakaan.Models.Book> Book { get; set; }
    }
}
