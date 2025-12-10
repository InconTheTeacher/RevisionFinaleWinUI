using HalloWinUI.Data.Models;
using System;

namespace HalloWinUI.ViewModels
{
    public class MaisonViewModel : BaseViewModel
    {
        private Maison _maison;

        public MaisonViewModel(Maison maison)
        {
            _maison = maison;
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

        public string CodePostal
        {
            get => _maison.CodePostal;
            set
            {
                if (_maison.CodePostal != value)
                {
                    _maison.CodePostal = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Ville
        {
            get => _maison.Ville;
            set
            {
                if (_maison.Ville != value)
                {
                    _maison.Ville = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool EstSignalee
        {
            get => _maison.EstSignalee;
            set
            {
                if (_maison.EstSignalee != value)
                {
                    _maison.EstSignalee = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(StatutTexte));
                    RaisePropertyChanged(nameof(StatutCouleur));
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
