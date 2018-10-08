using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP2.Models
{
    public class Rider
    {
        public int RiderID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int CountryID { get; set; }

        public int TeamID { get; set; }

        public String Bike { get; set; }
        public int Number { get; set; }




    }
}
