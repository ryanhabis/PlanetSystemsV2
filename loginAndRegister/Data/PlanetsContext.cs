using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using starSystems.Models;

namespace starSystems.Data
{
    public class PlanetsContext : DbContext
    {
        public PlanetsContext (DbContextOptions<PlanetsContext> options)
            : base(options)
        {
        }
        public DbSet<starSystems.Models.StarSystems> Stars { get; set; }
        public DbSet<starSystems.Models.Planets> Planets { get; set; } = default!;
    }
}