using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class MainMenuPageViewModel : ViewModelBase
    {
        public MainMenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}