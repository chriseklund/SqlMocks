using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace SqlMocks.AdventureWorksDb.DAL.Helpers
{
    public class DbContextOptionBuilder<TContext> where TContext : DbContext
    {
        public DbContextOptions<TContext> GetDbContextOptions(DbConnection dbConnection) 
        {
            DbContextOptionsBuilder<TContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<TContext>();

            return dbContextOptionsBuilder.UseSqlServer(dbConnection)
                                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options;
                                          
                
        }
    }
}