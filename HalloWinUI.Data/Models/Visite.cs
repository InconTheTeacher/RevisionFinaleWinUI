using Microsoft.EntityFrameworkCore;

namespace HalloWinUI.Data.Models
{
    // La clé primaire de visite est composée de EnfantId, MaisonId et DateVisite
    [PrimaryKey(nameof(EnfantId), nameof(MaisonId), nameof(DateVisite))]
    public class Visite
    {
        public int EnfantId { get; set; }
        public Enfant Enfant { get; set; } = new Enfant();

        public int MaisonId { get; set; }
        public Maison Maison { get; set; } = new Maison();

        public DateTime DateVisite { get; set; }

    }
}
