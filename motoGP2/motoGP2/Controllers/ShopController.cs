using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motoGP2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderTicket()
        {
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }
    }
}