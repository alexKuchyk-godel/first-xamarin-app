using Prism.Navigation;
using Prism.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class SignInPageViewModel : ViewModelBase
    {
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged(nameof(IsEnableSignIn));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                RaisePropertyChanged(nameof(IsEnableSignIn));
            }
        }
        public bool IsEnableSignIn
        {
            get
            {
                return !string.IsNullOrEmpty(Email)
                    && !string.IsNullOrEmpty(Password);

            }
        }
        public ICommand SignIn => new Command(async () => await _dialogService.DisplayAlertAsync("Hello", Email, "Ok"));

        private string _email;
        private string _password;
        private readonly IPageDialogService _dialogService;

        public SignInPageViewModel(
            INavigationService navigationService,
            IPageDialogService dialogService)
            : base(navigationService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
        }
    }
}
