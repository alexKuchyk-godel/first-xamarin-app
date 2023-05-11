using System.Collections.Generic;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using MyFirstApp.Models;
using MyFirstApp.Views;
using Prism.AppModel;
using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class OnboardingPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        private int _position;

        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value);
        }

        public List<OnboardingModel> Data { get; } = new List<OnboardingModel>
        {
            new OnboardingModel
            {
                Info = "Useful places, services and links for your life",
                ImagePath = "onboarding1.png"
            },
            new OnboardingModel
            {
                Info = "Saved places and links",
                ImagePath = "onboarding2.png"
            },
            new OnboardingModel
            {
                Info = "Add your review or new contact",
                ImagePath = "onboarding3.png"
            }
        };

        public IAsyncCommand Continue => new AsyncCommand(async () => await OnContinueAsync());
        public IAsyncCommand Skip => new AsyncCommand(async () => await OnSkipAsync());

        public OnboardingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public void OnAppearing()
        {
            Position = 0;
        }

        public void OnDisappearing()
        {
        }

        public async Task OnContinueAsync()
        {
            if (Position + 1 != Data.Count)
                Position++;
            else
                await OnSkipAsync();
        }

        private async Task OnSkipAsync()
        {
            await NavigationService.NavigateAsync(nameof(SignInPage));
        }
    }
}