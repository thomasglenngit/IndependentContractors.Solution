using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Models
{
  public class IndependentContractsContext : DbContext
  {
    public virtual DbSet<Client> Clients {get; set;}
    public virtual DbSet<Contractor> Contractors {get; set;}
    public virtual DbSet<Organization> Organizations {get;set;}
    public virtual DbSet<Armory> Armories {get;set;}
    public DbSet<ContractorArmory> ContractorArmory {get;set;}
    public DbSet<ClientContractor> ClientContractor {get; set;}
    public IndependentContractsContext(DbContextOptions options): base(options) {}
  }
}