using MauiMemory.Services;

namespace MauiMemory.Pages;

public partial class Page2 : ContentPage
{
    private readonly INavigationService _navigation;
    private byte[] _big;
    public Page2(INavigationService navigation)
    {
        InitializeComponent();
        _navigation = navigation;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _big = new byte[100 * 1024 * 1024];
        Random rng = new Random();
        rng.NextBytes(_big);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _big = null;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await _navigation.navigateToAsync(NavigationService.Home);
    }
}