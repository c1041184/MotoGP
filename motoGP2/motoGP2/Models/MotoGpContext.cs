using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP2.Models
{
    public class MotoGpContext : DbContext
    {
        public MotoGpContext(DbContextOptions<MotoGpContext> options) : base(options) {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
