using HalloWinUI.Data.Models;
using HalloWinUI.Data.Models.EnumPersonnalises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public class MaisonDataProvider : IMaisonDataProvider
    {
        private HalloWinUIDbContext _contexte { get; }

        public MaisonDataProvider(HalloWinUIDbContext contexte)
        {
            _contexte = contexte;
        }

        public Maison? GetMaisonParId(int id)
        {
            return _contexte.Maisons.Find(id);
        }

        public List<Maison> GetMaisons()
        {
            return _contexte.Maisons.ToList();
        }

        public void AjouterMaison(Maison maison)
        {
            _contexte.Maisons.Add(maison);
            _contexte.SaveChanges();
        }
    }
}
