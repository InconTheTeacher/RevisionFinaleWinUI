using HalloWinUI.Data.Models;
using System;

namespace HalloWinUI.ViewModels
{
    public class MaisonVisiteeViewModel : BaseViewModel
    {
        private Maison _maison;

        public MaisonVisiteeViewModel(Maison maison, DateTime dateVisite)
        {
            _maison = maison;
            DateVisite = dateVisite;
        }

        public int Id
        {
            get => _maison.Id;
        }

        public string Adresse
        {
            get => _maison.Adresse;
            set
            {
                if (_maison.Adresse != value)
                {
                    _maison.Adresse = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime DateVisite { get; }

        public bool EstSignalee
        {
            get => _maison.EstSignalee;
            set
            {
                if (_maison.EstSignalee != value)
                {
                    _maison.EstSignalee = value;
                }
            }
        }

        public string StatutTexte
        {
            get
            {
                return _maison.EstSignalee ? "SIGNALÉE" : "Sécuritaire";
            }
        }

        public string StatutCouleur
        {
            get 
            { 
                return EstSignalee ? "Red" : "Green";  
            }
        }

    }
}
