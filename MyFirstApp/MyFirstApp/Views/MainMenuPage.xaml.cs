using MyFirstApp.Constants;
using Xamarin.Forms;

namespace MyFirstApp.Views
{
    // todo: refactor according to MVVM 
    public partial class MainMenuPage : TabbedPage
    {
        private readonly Image _image;

        public MainMenuPage()
        {
            _image = new Image
            {
                Source = "map.png",
                Margin = GetMargin(),
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.End
            };
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if (CurrentPage.Title.Equals(MainMenuConstants.Search))
            {
                NavigationPage.SetTitleView(this, _image);
            }
            else
            {
                Title = CurrentPage.Title;
                NavigationPage.SetTitleView(this, null);
            }
        }

        private static Thickness GetMargin()
        {
            return Device.RuntimePlatform == Device.Android ?
                new Thickness(0, 0, 15, 0) :
                new Thickness(0, 15, 0, 0);
        }
    }
}