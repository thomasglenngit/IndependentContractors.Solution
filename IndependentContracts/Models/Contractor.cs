using System.Collections.Generic;

namespace IndependentContracts.Models
{
  public class Contractor
  {
    public Contractor()
    {
      this.Clients = new HashSet<ClientContractor>();
      this.Armories = new HashSet<ContractorArmory>();
    }
    public int ContractorId {get;set;}
    public string Alias {get;set;}
    public string RegionOfOperation {get;set;}
    public virtual ICollection<ClientContractor> Clients {get;set;}
    public virtual ICollection<ContractorArmory> Armories {get;set;}
  }
}