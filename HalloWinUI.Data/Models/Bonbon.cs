using HalloWinUI.Data.Models.EnumPersonnalises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Models
{
    public class Bonbon
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public int Quantite { get; set; }
        public CategorieBonbon Categorie { get; set; }
    }
}
