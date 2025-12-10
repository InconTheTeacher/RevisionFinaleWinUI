using HalloWinUI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public class VisiteDataProvider : IVisiteDataProvider
    {
        private HalloWinUIDbContext _context { get; }

        public VisiteDataProvider(HalloWinUIDbContext context)
        {
            _context = context;
        }

        public List<(Maison Maison, DateTime DateVisite)> GetMaisonsVisiteesParEnfant(int enfantId)
        {

            // TODO: Indice

            //.Select(v => new
            //    {
            //        Maison = v.Maison,
            //        DateVisite = v.DateVisite
            //    })

            throw new NotImplementedException();
        }
    }
}
