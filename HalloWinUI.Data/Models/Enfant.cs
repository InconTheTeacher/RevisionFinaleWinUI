using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Models
{
    public class Enfant
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public List<Visite> Visites { get; set; } = [];
    }
}
