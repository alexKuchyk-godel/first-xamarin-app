using System;
using AsyncAwaitBestPractices.MVVM;
using Prism.Navigation;
using Prism.Services;

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

        public IAsyncCommand SignIn => new AsyncCommand(async () =>
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