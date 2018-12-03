using motoGP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP2.ViewModels
{
    public class ConfirmOrderViewModel
    {
        public Ticket Ticket { get; set; }
        public Race Race { get; set; }

    }
}
