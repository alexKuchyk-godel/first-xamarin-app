using System;
using AsyncAwaitBestPractices.MVVM;
using MyFirstApp.Views;
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
            set => SetProperty(ref _email, value, nameof(IsEnableSignIn));
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value, nameof(IsEnableSignIn));
        }

        public bool IsEnableSignIn =>
            !string.IsNullOrEmpty(Email)
            && !string.IsNullOrEmpty(Password);

        public IAsyncCommand SignIn => new AsyncCommand(async () =>
            await NavigationService.NavigateAsync(nameof(MainMenuPage)));

        public SignInPageViewModel(
            INavigationService navigationService,
            IPageDialogService dialogService)
            : base(navigationService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
        }
    }
}