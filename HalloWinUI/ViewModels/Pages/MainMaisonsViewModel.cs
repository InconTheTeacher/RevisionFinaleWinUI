using HalloWinUI.Data.Data;
using HalloWinUI.Data.Models;
using HalloWinUI.Data.Models.EnumPersonnalises;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HalloWinUI.ViewModels.Pages
{
    public class MainMaisonsViewModel : BaseViewModel
    {
        private readonly IMaisonDataProvider _maisonDataProvider;
        private string _adresse;
        private string _codePostal;
        private string _ville;
        private bool _estSignalee;

        private MaisonViewModel? _maisonSelectionnee;

        public ObservableCollection<MaisonViewModel> Maisons { get; }

        public MaisonViewModel MaisonSelectionnee
        {
            get => _maisonSelectionnee;
            set
            {
                if (_maisonSelectionnee != value)
                {
                    _maisonSelectionnee = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Adresse
        {
            get => _adresse;
            set
            {
                if (_adresse != value)
                {
                    _adresse = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string CodePostal
        {
            get => _codePostal;
            set
            {
                if (_codePostal != value)
                {
                    _codePostal = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Ville
        {
            get => _ville;
            set
            {
                if (_ville != value)
                {
                    _ville = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool EstSignalee
        {
            get => _estSignalee;
            set
            {
                if (_estSignalee != value)
                {
                    _estSignalee = value;
                    RaisePropertyChanged();
                }
            }
        }

        private FiltreMaisonStatut _filtreStatut;

        public List<FiltreMaisonStatut> FiltresDisponibles { get; }

        public FiltreMaisonStatut FiltreStatut
        {
            get => _filtreStatut;
            set
            {
                if (_filtreStatut != value)
                {
                    _filtreStatut = value;
                    RaisePropertyChanged();
                    ChargerMaisons();
                }
            }
        }


        public MainMaisonsViewModel(IMaisonDataProvider maisonDataProvider)
        {
            _maisonDataProvider = maisonDataProvider;
            Maisons = new ObservableCollection<MaisonViewModel>();
            FiltresDisponibles = Enum.GetValues(typeof(FiltreMaisonStatut))
                                        .Cast<FiltreMaisonStatut>()
                                        .ToList();
            FiltreStatut = FiltreMaisonStatut.Toutes;
        }

        public void ChargerMaisons()
        {
            Maisons.Clear();
            List<Maison> maisons = _maisonDataProvider.GetMaisons();

            if (maisons != null)
            {
                foreach (Maison maison in maisons)
                {
                    MaisonViewModel maisonVM = new MaisonViewModel(maison);
                    Maisons.Add(maisonVM);
                }
            }
        }

        public void AjouterMaison()
        {
            throw new NotImplementedException();
        }

        private void ViderFormulaire()
        {
            Adresse = string.Empty;
            CodePostal = string.Empty;
            Ville = string.Empty;
            EstSignalee = false;
        }
    }
}
