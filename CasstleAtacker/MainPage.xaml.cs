using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CasstleAtacker.ViewModels;

namespace CastleAttacker
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.StartAttack();
        }
    }
}
