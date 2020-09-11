using Microsoft.EntityFrameworkCore;
using SqlMocks.DAL.Core.Entities;


namespace SqlMocks.AdventureWorksDb.DAL.DbContexts
{
    public class AutomationDbContext : DbContext
    {
        public string _cnString;
        public AutomationDbContext(DbContextOptions<AutomationDbContext> options)
            : base(options)
        {          
        }
                
        public DbSet<BillOfMaterials> BillOfMaterials { get; set; }

        public DbSet<Product> Products { get; set; }
                
        public DbSet<Employee> Employees { get; set; }

    }
}
