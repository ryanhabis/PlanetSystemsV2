using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace starSystems.Models
{
    public class PlanetsStarSystemViewModel
    {
        public List<Planets>? Planets { get; set; }
        public SelectList? starSystem { get; set; }
        public string? PlanetStarSystem { get; set; }
        public string? SearchString { get; set; }
    }
}
