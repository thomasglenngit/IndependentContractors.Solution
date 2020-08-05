using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Models
{
  public class IndependentContractsContext : DbContext
  {
    public virtual DbSet<Client> Clients {get; set;}
    public virtual DbSet<Contractor> Contractors {get; set;}
    public DbSet<ClientContractor> ClientContractor {get; set;}
    public IndependentContractsContext(DbContextOptions options): base(options) {}
  }
}