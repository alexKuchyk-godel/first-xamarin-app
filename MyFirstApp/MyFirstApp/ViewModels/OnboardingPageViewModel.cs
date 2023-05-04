﻿using MyFirstApp.Models;
using MyFirstApp.Views;
using Prism.AppModel;
using Prism.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class OnboardingPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        private int _position;
        public int Position
        {
            get => _position;
            set
            {
                _position = value;
                RaisePropertyChanged();
            }
        }
        public List<OnboardingModel> Data { get; set; } = new List<OnboardingModel>
            {
                new OnboardingModel{
                    Info = "Useful places, services and links for your life",
                    ImagePath = "onboarding1.png" },
                 new OnboardingModel{
                    Info = "Saved places and links",
                    ImagePath = "onboarding2.png" },
                  new OnboardingModel{
                    Info = "Add your review or new contact",
                    ImagePath = "onboarding3.png" }
            };

        public ICommand Continue => new Command(async () => await OnContinueAsync());
        public ICommand Skip => new Command(async () => await OnSkipAsync());

        public OnboardingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public async Task OnContinueAsync()
        {
            if (Position + 1 != Data.Count)
            {
                Position++;
            }
            else
            {
                await OnSkipAsync();
            }
        }

        private async Task OnSkipAsync()
        {
            await NavigationService.NavigateAsync(nameof(SignInPage));
        }

        public void OnAppearing()
        {
            Position = 0;
        }

        public void OnDisappearing()
        {
            return;
        }
    }
}