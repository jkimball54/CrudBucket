using CrudBucketMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBucketMVC.DataAccess
{
    public class CrudBucketContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public CrudBucketContext(DbContextOptions<CrudBucketContext> options) : base(options)
        {
            
        }
    }
}
