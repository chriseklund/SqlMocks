using Microsoft.EntityFrameworkCore;

namespace SqlMocks.TestAutomation.Test
{
    public class DbContextOptionBuilder<TContext> where TContext : DbContext
    {
        public DbContextOptions<TContext> GetDbContextOptions(string cnString) 
        {
            DbContextOptionsBuilder<TContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<TContext>();

            return dbContextOptionsBuilder.UseSqlServer(cnString)
                                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options;
                
        }
    }
}