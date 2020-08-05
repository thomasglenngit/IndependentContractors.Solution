using System.Collections.Generic;

namespace IndependentContracts.Models
{
  public class ClientContractor
  {
    public int ClientContractorId {get;set;}
    public int ClientId {get;set;}
    public int ContractorId {get;set;}
    public Client Client {get;set;}
    public Contractor Contractor {get;set;}
  }
}