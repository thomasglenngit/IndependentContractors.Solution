using System.Collections.Generic;

namespace IndependentContracts.Models
{
  public class Client
  {
    public Client()
    {
      this.Contractors = new HashSet<ClientContractor>();
    }
    public int ClientId {get;set;}
    public string Name {get;set;}
    public virtual ICollection<ClientContractor> Contractors {get;set;}
  }
}