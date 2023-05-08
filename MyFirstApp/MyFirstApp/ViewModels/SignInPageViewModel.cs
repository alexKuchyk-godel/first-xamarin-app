using System;
using System.Windows.Input;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class SignInPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService _dialogService;

        private string _email;
        private string _password;

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

        public bool IsEnableSignIn =>
            !string.IsNullOrEmpty(Email)
            && !string.IsNullOrEmpty(Password);

        public ICommand SignIn => new Command(async () =>
            await _dialogService.DisplayAlertAsync("Hello", Email, "Ok"));

        public SignInPageViewModel(
            INavigationService navigationService,
            IPageDialogService dialogService)
            : base(navigationService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
        }
    }
}