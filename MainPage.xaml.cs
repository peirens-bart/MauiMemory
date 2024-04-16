using MauiMemory.Services;

namespace MauiMemory
{
    public partial class MainPage : ContentPage
    {
        private readonly INavigationService _navigation;
        public MainPage(INavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;

        }

        private async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            await _navigation.navigateToAsync(NavigationService.Page1);
        }

        private async void CounterBtn2_Clicked(object sender, EventArgs e)
        {
            await _navigation.navigateToAsync(NavigationService.Page2);
        }
    }

}
