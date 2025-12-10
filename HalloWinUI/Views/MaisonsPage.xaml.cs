using HalloWinUI.Data;
using HalloWinUI.Data.Data;
using HalloWinUI.ViewModels;
using HalloWinUI.ViewModels.Pages;
using HalloWinUI.Views.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HalloWinUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MaisonsPage : Page
    {
        public MainMaisonsViewModel ViewModel { get; }

        public MaisonsPage()
        {
            InitializeComponent();
            var context = new HalloWinUIDbContext();
            ViewModel = new MainMaisonsViewModel(new MaisonDataProvider(context));
            root.Loaded += Root_Loaded;
        }

        private void Root_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.ChargerMaisons();
        }

        private void btnAjouterMaison_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AjouterMaison();
        }

        private async void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.MaisonSelectionnee == null)
            {
                return;
            }
        }
    }
}
