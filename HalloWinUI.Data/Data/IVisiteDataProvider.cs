using HalloWinUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public interface IVisiteDataProvider
    {
        // Retourne une liste de tuples
        List<(Maison Maison, DateTime DateVisite)> GetMaisonsVisiteesParEnfant(int enfantId);



    }
}
