using HalloWinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace HalloWinUI.Views.Controls
{
    public sealed partial class MaisonFormControl : UserControl
    {
        public MaisonViewModel MaisonVM { get; set; } 
        public MaisonFormControl(MaisonViewModel maisonVM)
        {
            MaisonVM  = maisonVM;
            InitializeComponent();
        }
    }
}
