using Microsoft.AspNetCore.Mvc.Rendering;
using motoGP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace motoGP2.ViewModels
{
    public class OrderTicketViewModel
    {
        public Ticket ticket { get; set; }
        public SelectList Countries { get; set; }
        public SelectList Races { get; set; }
    }
}
