using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Architecture.Database;

public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        const string connectionString = "Host=database;Database=Database;User Id=pa;Password=P4ssW0rd!";

        return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).UseLowerCaseNamingConvention().Options);
    }
}
