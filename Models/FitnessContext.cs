using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitnessService.Models
{
    public class FitnessContext : DbContext
    {
        public DbSet<CoachModel> Coaches { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<RateModel> Rates { get; set; }

        public FitnessContext(DbContextOptions<FitnessContext> options)
            : base(options)
        {

             Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
