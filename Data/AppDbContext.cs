using Microsoft.EntityFrameworkCore;
using wholesale_store.Models.Entities;

namespace wholesale_store.Data
{
    public class AppDbC :DbContext
    {
        public AppDbC(DbContextOptions<AppDbC> options):base(options) 
        {
            
        }
        public DbSet<Tasks> Tasks { get; set; }

    }
}
