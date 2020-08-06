using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace IndependentContracts.Models
{
  public class Client
  {
    public Client()
    {
      this.Contractors = new HashSet<ClientContractor>();
    }
    public int ClientId {get;set;}
    public int? OrganizationId {get;set;}
    public string Name {get;set;}
    public DateTime accountCreationDate {get;set;} = DateTime.Now;
    public virtual ICollection<ClientContractor> Contractors {get;set;}
    public virtual Organization Organization {get;set;}
  }
}