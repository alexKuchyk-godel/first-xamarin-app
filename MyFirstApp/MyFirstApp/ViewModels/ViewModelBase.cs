﻿using Prism.Mvvm;
using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        private string _title;

        protected INavigationService NavigationService { get; private set; }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Destroy()
        {
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}