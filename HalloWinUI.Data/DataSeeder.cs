using HalloWinUI.Data.Models;
using HalloWinUI.Data.Models.EnumPersonnalises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data
{
    public class DataSeeder
    {
        private HalloWinUIDbContext _context;

        public DataSeeder(HalloWinUIDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (_context.Enfants.Any() || _context.Maisons.Any() || _context.Bonbons.Any())
                return;

            List<Maison> maisons = new List<Maison>
            {
                new Maison
                {
                    Adresse = "123 Rue des Fantômes",
                    CodePostal = "H2X 1Y7",
                    Ville = "Montréal",
                    EstSignalee = true
                },
                new Maison
                {
                    Adresse = "456 Avenue des Citrouilles",
                    CodePostal = "G1R 2B5",
                    Ville = "Québec",
                    EstSignalee = false
                },
                new Maison
                {
                    Adresse = "789 Boulevard Hanté",
                    CodePostal = "J4H 3M2",
                    Ville = "Longueuil",
                    EstSignalee = false
                },
                new Maison
                {
                    Adresse = "321 Chemin des Sorcières",
                    CodePostal = "H3Z 2Y7",
                    Ville = "Montréal",
                    EstSignalee = false
                }
            };

            List<Enfant> enfants = new List<Enfant>
            {
                new Enfant{ Nom = "Sophie" },
                new Enfant{ Nom = "Lucas" },
                new Enfant{ Nom = "Emma" }
            };

            List<Visite> visites = new List<Visite>
            {
                new Visite { Enfant = enfants[0], Maison = maisons[0], DateVisite = DateTime.Now.AddMinutes(-30) },
                new Visite { Enfant = enfants[0], Maison = maisons[1], DateVisite = DateTime.Now.AddMinutes(-20) },
                new Visite { Enfant = enfants[0], Maison = maisons[3], DateVisite = DateTime.Now.AddMinutes(-10) },

                new Visite { Enfant = enfants[1], Maison = maisons[1], DateVisite = DateTime.Now.AddMinutes(-25) },
                new Visite { Enfant = enfants[1], Maison = maisons[2], DateVisite = DateTime.Now.AddMinutes(-5) },

                new Visite { Enfant = enfants[2], Maison = maisons[0], DateVisite = DateTime.Now.AddMinutes(-50) },
                new Visite { Enfant = enfants[2], Maison = maisons[1], DateVisite = DateTime.Now.AddMinutes(-40) },
                new Visite { Enfant = enfants[2], Maison = maisons[2], DateVisite = DateTime.Now.AddMinutes(-30) },
                new Visite { Enfant = enfants[2], Maison = maisons[3], DateVisite = DateTime.Now.AddMinutes(-15) }
            };
        }
    }
}
