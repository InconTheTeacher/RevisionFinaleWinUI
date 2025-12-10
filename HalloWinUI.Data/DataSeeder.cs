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

            _context.Maisons.AddRange(maisons);
            _context.SaveChanges();

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

            _context.Enfants.AddRange(enfants);
            _context.SaveChanges();

            List<Bonbon> bonbons = new List<Bonbon>()
            {
                new Bonbon {Nom = "Chocolait", Quantite = 20, Categorie = CategorieBonbon.Chocolat, Maison = maisons[0]},
                new Bonbon {Nom = "Chippeur", Quantite = 250, Categorie = CategorieBonbon.Chips, Maison = maisons[0]},
                new Bonbon {Nom = "Sucretur", Quantite = 120, Categorie = CategorieBonbon.Sucreries, Maison = maisons[0]},
                new Bonbon {Nom = "Gomme à effacer", Quantite = 122, Categorie = CategorieBonbon.Gommes, Maison = maisons[0]},
                new Bonbon {Nom = "Citrouille en pain d'épices", Quantite = 63, Categorie = CategorieBonbon.Autre, Maison = maisons[0]},
                
                new Bonbon {Nom = "Cheap-O's", Quantite = 576, Categorie = CategorieBonbon.BonbonsDurs, Maison = maisons[1]},
                new Bonbon {Nom = "Pomme mini", Quantite = 93, Categorie = CategorieBonbon.Autre, Maison = maisons[1]},
                new Bonbon {Nom = "Sucralosier", Quantite = 147, Categorie = CategorieBonbon.Sucreries, Maison = maisons[1]},
                
                new Bonbon {Nom = "Chip à la craie", Quantite = 210, Categorie = CategorieBonbon.Chips, Maison = maisons[2]},
                new Bonbon {Nom = "Gomme Balloune Premium", Quantite = 72, Categorie = CategorieBonbon.Gommes, Maison = maisons[2]},
                new Bonbon {Nom = "Fructorie", Quantite = 250, Categorie = CategorieBonbon.Sucreries, Maison = maisons[2]}

            };

            _context.Bonbons.AddRange(bonbons);
            _context.SaveChanges();
        }
    }
}
