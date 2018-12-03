using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using motoGP2.Models;
using motoGP2.ViewModels;

namespace motoGP2.Controllers
{
    public class ShopController : Controller
    {
        MotoGpContext motoGpContext;

        public ShopController(MotoGpContext _motogpContext)
        {
            this.motoGpContext = _motogpContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderTicket()
        {
            OrderTicketViewModel orderTicketVM = new OrderTicketViewModel();
            orderTicketVM.Countries=getCountries();
            orderTicketVM.Races = getRaces();
            return View(orderTicketVM);
        }
        [HttpPost]
        public IActionResult ConfirmOrder(OrderTicketViewModel orderTicketViewModel)
        {
            Ticket ticket = orderTicketViewModel.ticket;

            
            ticket.Paid = false;
            ticket.OrderDate = System.DateTime.Now;
            //ticket.RaceID = 1;
            

            motoGpContext.Tickets.Add(ticket);
            motoGpContext.SaveChanges();

            return RedirectToAction("ConfirmOrder", new {ticketId = ticket.TicketID } );

        }

        public  IActionResult ConfirmOrder(int ticketId)
        {

            ConfirmOrderViewModel confirmOrderVM = new ConfirmOrderViewModel();
            confirmOrderVM.Ticket   = this.motoGpContext.Tickets.Where(t => t.TicketID == ticketId).SingleOrDefault();
            confirmOrderVM.Race = this.motoGpContext.Races.Where(r => r.RaceID == confirmOrderVM.Ticket.RaceID).Single(); ;
            return View(confirmOrderVM);
        }



      

        private SelectList getCountries()
        {
            List<Country> listCountries = this.motoGpContext.Countries.ToList();      
            SelectList sl = new SelectList(listCountries, "CountryID", "Name");
            return sl ;
        }

        private SelectList getRaces()
        {
            List<Race> listRaces = this.motoGpContext.Races.ToList();
            SelectList sl = new SelectList(listRaces, "RaceID", "Name");
            return sl;

        }




    }
}