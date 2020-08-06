using System.Collections.Generic;

namespace IndependentContracts.Models
{
  public class Organization
  {
    public Organization()
    {
      this.Clients = new HashSet<Client>();
    }
    public int OrganizationId {get;set;}
    public string Name {get;set;}
    public virtual ICollection<Client> Clients {get;set;}
  }
}