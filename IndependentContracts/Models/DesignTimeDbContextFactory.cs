using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace IndependentContracts.Models
{
  public class IndependentContractsContextFactory : IDesignTimeDbContextFactory<IndependentContractsContext>
  {

    IndependentContractsContext IDesignTimeDbContextFactory<IndependentContractsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<IndependentContractsContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new IndependentContractsContext(builder.Options);
    }
  }
}