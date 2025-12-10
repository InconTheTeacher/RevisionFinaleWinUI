using HalloWinUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.Data.Data
{
    public interface IEnfantsDataProvider
    {
        public List<Enfant> GetEnfants();

    }
}
