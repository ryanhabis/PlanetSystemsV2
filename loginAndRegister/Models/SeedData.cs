using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using starSystems.Data;
using System;
using System.Linq;

namespace starSystems.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlanetsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlanetsContext>>()))
            {
                // Look for any Planets.
                if (context.Planets.Any())
                {
                    return;   // DB has been seeded
                }
                context.Planets.AddRange(
                new Planets
                {
                  //  Id = 1,
                    Title = "Mercury",
                    Description = "the smallest planet in our solar system and nearest to the Sun—is only slightly larger than Earth's Moon. Its surface is covered in tens of thousands of impact craters.",
                    StarId = 1,
                    StarSystem = "Solar"
                },
                new Planets
                {
                    //Id = 2,
                    Title = "Venus",
                    Description = "Venus is the second planet from the Sun, and the sixth largest planet. It’s the hottest planet in our solar system.",
                    StarId = 1,
                    StarSystem = "Solar"

                },
                 new Planets
                 {
                    // Id = 3,
                     Title = "Earth",
                     Description = "Earth – our home planet – is the third planet from the Sun, and the fifth largest planet. It's the only place we know of inhabited by living things.\r\n\r\n",
                     StarId = 1,
                     StarSystem = "Solar"

                 },
                  new Planets
                  {
                  //    Id = 4,
                      Title = "Mars",
                      Description = "Mars is the fourth planet from the Sun, and the seventh largest. It’s the only planet we know of inhabited entirely by robots.\r\n\r\n",
                      StarId = 1,
                      StarSystem = "Solar"

                  },
                   new Planets
                   {
                      // Id = 5,
                       Title = "Jupiter",
                       Description = "Jupiter is the fifth planet from the Sun, and the largest in the solar system – more than twice as massive as the other planets combined.\r\n\r\n",
                       StarId = 1,
                       StarSystem = "Solar"

                   },
                   new Planets
                   {
                      // Id = 6,
                       Title = "Saturn",
                       Description = "Saturn is the sixth planet from the Sun, and the second largest in the solar system. It’s surrounded by beautiful rings.\r\n\r\n",
                       StarId = 1,
                       StarSystem = "Solar"

                   },
                   new Planets
                   {
                    //   Id = 7,
                       Title = "Uranus",
                       Description = "Uranus is the seventh planet from the Sun, and the third largest planet in our solar system. It appears to spin sideways.\r\n\r\n",
                       StarId = 1,
                       StarSystem = "Solar"

                   },
                   new Planets
                   {
                      // Id = 8,
                       Title = "Neptune",
                       Description = "Neptune is the eighth, and most distant planet from the Sun. It’s the fourth-largest, and the first planet discovered with math.\r\n\r\n",
                       StarId = 1,
                       StarSystem = "Solar"

                   },
                   new Planets
                   {
                    //   Id = 9,
                       Title = "Dwarf Planets",
                       Description = "Our solar system has five dwarf planets. In order of distance from the Sun they are: Ceres, Pluto, Haumea, Makemake, and Eris.\r\n\r\n",
                       StarId = 1,
                       StarSystem = "Solar"

                   },
                   // Trappist-1 star system
                   new Planets
                   {
                      // Id = 10,
                       Title = "TRAPPIST-1b",
                       Description = "the innermost planet in the TRAPPIST-1 system, is a rocky world that's similar in size to Earth. With a diameter of 8,846 miles (14,236 km), TRAPPIST-1b is about 1.116 times larger than our planet and 1.374 times as massive, according to NASA. TRAPPIST-1b's surface gravity is 10% stronger than Earth's. \r\n\r\n",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                     //  Id = 11,
                       Title = "TRAPPIST-1C",
                       Description = "TRAPPIST-1c has a measured surface temperature of 225 F (107 C). Laura Kreidberg, an astronomer at the Max Planck Institute for Astronomy in Germany, describes TRAPPIST-1c as being interesting because \"it's basically a Venus twin: it's about the same size as Venus and receives a similar amount of radiation from its host star as Venus gets from the Sun.\"\r\n\r\nWith a diameter of 8,718 miles (14,030 km), TRAPPIST-1c is 1.097 times larger than Earth and 1.308 times as massive, and its surface gravity is just a shade below our planet's. It orbits TRAPPIST-1 every 2.4 Earth days at a distance of 1.47 million miles (2.36 million km).\r\n\r\n",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                     //  Id = 12,
                       Title = "TRAPPIST-1D",
                       Description = "This diminutive world is one of the least massive exoplanets discovered anywhere so far, and it has a slim chance of being habitable. Orbiting at a distance of 2.07 million miles (3.33 million km) every 4.05 Earth days, TRAPPIST-1d is on the inner edge of the red dwarf's habitable zone, with the planet receiving 4.3% more starlight than Earth does from the sun. \r\n\r\nTRAPPIST-1d has a diameter of 6,246 miles (10,050 km) — just 0.788 times that of Earth — and only 38.8% of Earth's mass. Its surface gravity is less than half our planet's gravitational pull, meaning it would be even more difficult for TRAPPIST-1d to hang onto its atmosphere. And even if it could, planetary scientists at the University of Washington who have modeled the TRAPPIST-1 system think TRAPPIST-1d would be more likely to have a runaway greenhouse effect like Venus than be habitable like Earth.\r\n\r\n",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                       //Id = 13,
                       Title = "TRAPPIST-1E",
                       Description = "The best chance for a habitable environment in the TRAPPIST-1 system is TRAPPIST-1e, which lies in the middle of the habitable zone at a distance of 2.73 million miles (4.4 million km) from its star, according to NASA. Orbiting every 6.1 Earth days, TRAPPIST-1e is smaller than Earth, with a diameter of 7,292 miles (11,736 km) — just 0.92 times our planet's — and 69% Earth's mass, equating to a surface gravity of 93% that of Earth. \r\n\r\nTRAPPIST-1e receives about the same amount of light from its star as Earth does from the sun, meaning that if this exoplanet has an atmosphere to retain some of the heat it receives, TRAPPIST-1e would be warm enough for liquid water on its surface.\r\n\r\n",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                       //Id = 14,
                       Title = "TRAPPIST-1F",
                       Description = "Lurking on the outer edge of the habitable zone is TRAPPIST-1f, which orbits the red dwarf star every 9.2 Earth days at a distance of 3.57 million miles (5.74 million km). It's roughly Earth-size, with a diameter of 8,282 miles (13,330 km) — 1.045 times that of Earth — and 93% Earth's mass. \r\n\r\nTRAPPIST-1f's surface gravity is 85.3% that of Earth, and it receives only a third of the sunlight as our planet does from the sun. As such, TRAPPIST-1f is probably a lot cooler; without an atmosphere, its temperature would be minus 74 F (minus 59 C), but with a very thick atmosphere, perhaps bolstered by volcanic gases, its temperature might, in theory, creep above the freezing point.",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                       //Id = 15,
                       Title = "TRAPPIST-1G",
                       Description = "A true \"super-Earth,\" TRAPPIST-1g is an outside bet for habitability. This big, rocky planet has a diameter 1.129 times that of Earth (8,950 miles, or 14,400 km) and a mass 30% greater than our planet's. It orbits the star every 12.4 Earth days at a distance of 4.19 million miles (6.75 million km) . This probably places it just outside the habitable zone, where it receives just a quarter of the light from its star as Earth receives from the sun, meaning TRAPPIST-1g is likely covered in a frozen ocean. \r\n\r\nHowever, the exoplanet's large mass means that it could more easily retain its atmosphere against the radiation from its star trying to blow it away. If it has lots of volcanism replenishing its atmosphere with greenhouse gases or a thick shroud of hydrogen helping to keep it warm, TRAPPIST-1g could still have an ocean as a so-called Hycean world. ",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   },
                   new Planets
                   {
                      // Id = 16,
                       Title = "TRAPPIST-1H",
                       Description = "The outermost planet in the system, TRAPPIST-1h, orbits its star at a distance of 5.75 million miles (9.26 million km), completing one orbit every 18.9 days. TRAPPIST-1h's smaller size of just 0.775 times the diameter of Earth (6,142 miles, or 9,886 km) and one-third the mass of our planet means its surface gravity is just 57% of Earth's.\r\n\r\nA study with the Hubble Space Telescope concluded that the outer planets of TRAPPIST-1, including those in the habitable zone and TRAPPIST-1h, could have large amounts of water. Being beyond the habitable zone, TRAPPIST-1h is unlikely to have an ocean, however; it is probably a frozen ball of water ice measuring a frigid minus 148 F (minus 100 C).\r\n\r\n",
                       StarId = 2,
                       StarSystem = "TRAPPIST-1"

                   }
                );



                //using (var context = new StarSystemsContext(
                // serviceProvider.GetRequiredService<
                //       DbContextOptions<StarSystemsContext>>()))
                // {
                // Look for any StarSystems.
                if (!context.Stars.Any())
                {
                    //    return;   // DB has been seeded

                    context.Stars.AddRange(
                    new StarSystems
                    {
                       // StarId = 1,
                        StarName = "Solar",
                        Description = "Our solar system is made up of a star, eight planets, and countless smaller bodies such as dwarf planets, asteroids, and comets. Our solar system orbits the center of the Milky Way galaxy at about 515,000 mph (828,000 kph). We're in one of the galaxy's four spiral arms.",
                    },
                    new StarSystems
                    {
                       // StarId = 2,
                        StarName = "TRAPPIST-1 system",
                        Description = "Seven terrestrial planets orbit this star; several are super-Earths. JWST has just begun collecting data on these worlds, with recent measurements indicating that the innermost planet, TRAPPIST-1 b, does not have an atmosphere",
                    }
                    );
                }
                context.SaveChanges();

            }
        }
    }
}