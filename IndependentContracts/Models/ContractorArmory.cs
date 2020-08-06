using System.Collections.Generic;

namespace IndependentContracts.Models
{
  public class ContractorArmory
  {
    public int ContractorArmoryId {get;set;}
    public int ContractorId {get;set;}
    public int ArmoryId {get;set;}
    public Contractor Contractor {get;set;}
    public Armory Armory {get;set;}
  }
}