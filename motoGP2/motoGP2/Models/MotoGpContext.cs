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

        public DbSet<Country> Countries;
        public DbSet<Race> Races;
        public DbSet<Rider> Riders;
        public DbSet<Team> Teams;
        public DbSet<Ticket> Tickets;

    }
}
