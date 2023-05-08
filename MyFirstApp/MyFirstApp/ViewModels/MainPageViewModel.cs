using System.Windows.Input;
using AsyncAwaitBestPractices.MVVM;
using MyFirstApp.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public IAsyncCommand GetStarted =>
            new AsyncCommand(async () => await NavigationService.NavigateAsync(nameof(OnboardingPage)));

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}