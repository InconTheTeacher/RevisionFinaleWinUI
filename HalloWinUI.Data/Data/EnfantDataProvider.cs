using HalloWinUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public class EnfantDataProvider : IEnfantsDataProvider
    {
        private HalloWinUIDbContext _context;

        public EnfantDataProvider(HalloWinUIDbContext context)
        {
            _context = context;
        }
        public List<Enfant> GetEnfants()
        {
            return _context.Enfants.ToList();
        }
    }
}
