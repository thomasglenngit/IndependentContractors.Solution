using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Models
{
  public class IndependentContractsContext : DbContext
  {
    public DbSet<Client> Clients {get; set;}
    public DbSet<Contractor> Contractors {get; set;}
    public DbSet<Organization> Organizations {get;set;}
    public DbSet<Armory> Armories {get;set;}
    public DbSet<ContractorArmory> ContractorArmory {get;set;}
    public DbSet<ClientContractor> ClientContractor {get; set;}
    public IndependentContractsContext(DbContextOptions options): base(options) {}
  }
}