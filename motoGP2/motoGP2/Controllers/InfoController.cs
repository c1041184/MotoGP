using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using motoGP2.Models;

namespace motoGP2.Controllers
{
    public class InfoController : Controller
    {
        private MotoGpContext dbContext;

        public InfoController(MotoGpContext motoGpContext)
        {
            dbContext = motoGpContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListRaces()
        {
            IEnumerable<Race> races = dbContext.Races.OrderBy(r => r.Date);
            //return View();
            return View(races.ToList());
        }
        
        public IActionResult ShowRace(string id) 
        {
            
            var race = dbContext.Races.SingleOrDefault(r => r.RaceID.ToString()==id);
            return View(race);
        }
        public IActionResult ListTeams()
        {
            return View();
        }
        public IActionResult ListRiders()
        {
            var riders = dbContext.Riders.OrderBy(r => r.Number);
            return View(riders);
        }

        public IActionResult BuildMap()
        {
            IEnumerable<Race> races = dbContext.Races.OrderBy(r => r.Date);
            return View(races.ToList());

        }




    }
}