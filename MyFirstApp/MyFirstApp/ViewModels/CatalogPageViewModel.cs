using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class CatalogPageViewModel : ViewModelBase
    {
        public CatalogPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}