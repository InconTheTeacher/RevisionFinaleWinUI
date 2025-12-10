using HalloWinUI.Data.Models;
using HalloWinUI.Data.Models.EnumPersonnalises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public interface IMaisonDataProvider
    {
        public Maison? GetMaisonParId(int id);
        public List<Maison> GetMaisons();
        public void AjouterMaison(Maison maison);
    }
}
