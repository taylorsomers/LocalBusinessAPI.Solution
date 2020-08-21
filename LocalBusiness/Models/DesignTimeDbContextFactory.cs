using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LocalBusiness.Models
{
  public class LocalBusinessContextFactory : IDesignTimeDbContextFactory<LocalBusinessContext>
  {
    LocalBusinessContext IDesignTimeDbContextFactory<LocalBusinessContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<LocalBusinessContext>();

      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new LocalBusinessContext(builder.Options);
    }
  }
}