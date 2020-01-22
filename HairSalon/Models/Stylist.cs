using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class Stylist
    {
        // public Stylist()
        // {
        //     this.Clients = new HashSet<Client>();
        // }

        public int StylistId { get; set; }
        public string StylistName { get; set; }
        //public string Specialty { get; set; }
        //public string StylistTimeSlot { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        // public virtual ICollection<Client> Clients { get; set; }
    }
}