using HalloWinUI.Data.Data;
using HalloWinUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HalloWinUI.ViewModels.Pages
{
    public class MainVisitesViewModel : BaseViewModel
    {
        private readonly IEnfantsDataProvider _enfantDataProvider;
        private readonly IVisiteDataProvider _visiteDataProvider;
        private EnfantViewModel _enfantSelectionne;

        public List<EnfantViewModel> Enfants { get; }
        public ObservableCollection<MaisonVisiteeViewModel> MaisonsVisitees { get; }

        public EnfantViewModel EnfantSelectionne
        {
            get => _enfantSelectionne;
            set
            {
                if (_enfantSelectionne != value)
                {
                    _enfantSelectionne = value;
                    RaisePropertyChanged();
                    ChargerMaisonsVisitees();
                }
            }
        }

        public MainVisitesViewModel(IEnfantsDataProvider enfantDataProvider, IVisiteDataProvider visiteDataProvider)
        {
            _enfantDataProvider = enfantDataProvider;
            _visiteDataProvider = visiteDataProvider;
            Enfants = new List<EnfantViewModel>();
            MaisonsVisitees = new ObservableCollection<MaisonVisiteeViewModel>();
        }

        public void ChargerDonnees()
        {
            Enfants.Clear();

            List<Enfant> enfants = _enfantDataProvider.GetEnfants();
            if (enfants != null)
            {
                foreach (Enfant enfant in enfants)
                {
                    Enfants.Add(new EnfantViewModel(enfant));
                }
            }
        }

        private void ChargerMaisonsVisitees()
        {
            MaisonsVisitees.Clear();
            if (EnfantSelectionne != null)
            {
                List<(Maison, DateTime)> maisonsVisiteesVM = _visiteDataProvider.GetMaisonsVisiteesParEnfant(EnfantSelectionne.Id);

                foreach (var (maison, dateVisite) in maisonsVisiteesVM)
                {
                    MaisonsVisitees.Add(new MaisonVisiteeViewModel(maison, dateVisite));
                }
            }
        }
    }
}
