using System.Collections.Generic;
using MyFirstApp.Models;
using Prism.Navigation;

namespace MyFirstApp.ViewModels
{
    public class SavedPageViewModel : ViewModelBase
    {
        public List<SavedItemModel> Data { get; } = new List<SavedItemModel>
        {
            new SavedItemModel
            {
                Name = "Health 1",
                Address = "Wroclaw, Grodska 15",
                FeedBacksCount = 10,
                ImageSource = "abc.jpeg",
                Rating = 5
            },
            new SavedItemModel
            {
                Name = "Health 1",
                Address = "Wroclaw, Grodska 15",
                FeedBacksCount = 8,
                ImageSource = "abc.jpeg",
                Rating = 2
            },
            new SavedItemModel
            {
                Name = "Health 3",
                Address = "Wroclaw, Grodska 15",
                FeedBacksCount = 1,
                ImageSource = "abc.jpeg",
                Rating = 3.6
            }
        };

        public SavedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}