namespace HalloWinUI.Data.Models
{
    public class Maison
    {
        public int Id { get; set; }
        public string Adresse { get; set; } = string.Empty;
        public string CodePostal { get; set; } = string.Empty;
        public string Ville { get; set; } = string.Empty;
        public bool EstSignalee { get; set; }


    }
}
