using HalloWinUI.Data;
using HalloWinUI.Data.Data;
using HalloWinUI.ViewModels.Pages;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HalloWinUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VisitesPage : Page
    {
        public MainVisitesViewModel ViewModel { get; }

        public VisitesPage()
        {
            InitializeComponent();
            var context = new HalloWinUIDbContext();
            ViewModel = new MainVisitesViewModel(new EnfantDataProvider(context), new VisiteDataProvider(context));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // Recharger les données à chaque navigation
            ViewModel.ChargerDonnees();
        }
    }
}
