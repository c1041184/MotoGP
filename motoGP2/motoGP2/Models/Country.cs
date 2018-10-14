using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP2.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryID { get; set; }
        
        public String Name { get; set; }

        public ICollection<Rider> Riders { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
