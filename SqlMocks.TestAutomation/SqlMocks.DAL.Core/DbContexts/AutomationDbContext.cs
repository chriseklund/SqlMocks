using SqlMocks.DAL.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlMocks.DAL.Core.DbContexts
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
