using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class AddPageViewModel : ViewModelBase
    {
        public AddPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}