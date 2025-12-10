using HalloWinUI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HalloWinUI.Data
{
    public class HalloWinUIDbContext : DbContext
    {
        public HalloWinUIDbContext(DbContextOptions<HalloWinUIDbContext> options) : base(options) { }

        public HalloWinUIDbContext() : base() { }

        public DbSet<Models.Enfant> Enfants { get; set; }
        public DbSet<Models.Maison> Maisons { get; set; }
        public DbSet<Models.Visite> Visites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "HalloWinUI", "HalloWinUI.db");

                Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

                optionsBuilder
                    .UseSqlite($"Data Source={dbPath}")
                    .LogTo(
                    // Indiquer la sortie utilisée
                    delegate (string text) { Debug.WriteLine(text); },
                    // Indiquer les types de messages affichés (Array) si on veut filtrer 
                    [DbLoggerCategory.Database.Command.Name],
                    // Filtrer par sévérité (niveau minimum)
                    Microsoft.Extensions.Logging.LogLevel.Information)
                    // Ajouter pour afficher toutes les données    
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
