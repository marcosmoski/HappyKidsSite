using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HappyKids.Parties.EntityFrameworkCore
{
    public static class PartiesDbContextConfigurerPostgres
{
        public static void Configure(DbContextOptionsBuilder<PartiesDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PartiesDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
 }
}
