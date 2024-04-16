using MauiMemory.Services;

namespace MauiMemory.Pages;

public partial class Page1 : ContentPage
{
    private readonly INavigationService _navigation;
    public Page1(INavigationService navigation)
    {
        InitializeComponent();
        _navigation = navigation;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await _navigation.navigateToAsync(NavigationService.Home);
    }
}