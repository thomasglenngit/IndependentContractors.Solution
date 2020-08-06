using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace IndependentContracts.Models
{
  public class Armory
  {
    public Armory()
    {
      this.Contractors = new HashSet<ContractorArmory>();
    }
    public int ArmoryId {get;set;}
    public string WeaponName {get;set;}
    public virtual ICollection<ContractorArmory> Contractors {get;set;}
  }
}