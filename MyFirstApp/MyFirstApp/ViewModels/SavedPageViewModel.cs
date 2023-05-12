using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class SavedPageViewModel : ViewModelBase
    {
        public SavedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}