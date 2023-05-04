using MyFirstApp.Views;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand GetStarted => new Command(async () => await NavigationService.NavigateAsync(nameof(OnboardingPage)));

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
