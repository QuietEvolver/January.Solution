using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
        this.Stylists = new HashSet<Stylist>();
    }

    public int ClientId { get; set; } 
    // public string RequestedSpecialtyType { get; set; } ///Type
    public string ClientName { get; set; } //Name
    // public string ClientAddress { get; set; } //(Date field deleted)Gender
    // public int ClientPhone { get; set; } //Breed
    public int StylistId { get; set; }
    
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}