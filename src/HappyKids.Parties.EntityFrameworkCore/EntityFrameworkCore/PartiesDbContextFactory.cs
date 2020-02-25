using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HappyKids.Parties.Configuration;
using HappyKids.Parties.Web;

namespace HappyKids.Parties.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PartiesDbContextFactory : IDesignTimeDbContextFactory<PartiesDbContext>
    {
        public PartiesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PartiesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PartiesDbContextConfigurerPostgres.Configure(builder, configuration.GetConnectionString(PartiesConsts.ConnectionStringName));

            return new PartiesDbContext(builder.Options);
        }
    }
}
