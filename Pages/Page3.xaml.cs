using MauiMemory.Services;

namespace MauiMemory.Pages;

public partial class Page3 : ContentPage
{
    private readonly INavigationService _navigation;
    private readonly ICounterService _counterService;

    public Page3(INavigationService navigation, ICounterService counterService)
    {
        InitializeComponent();
        _navigation = navigation;
        _counterService = counterService; ;

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Console.WriteLine("Page3 OnAppearing");
        _counterService.Add();
        calledTxt.Text = $"Called:{_counterService.Count}";
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (_counterService.HasMaxReached())
        {
            Console.WriteLine("Page3 Go Home");
            _counterService.Reset();
            await _navigation.navigateToAsync(NavigationService.Home);
        }
        else
        {
            Console.WriteLine("Page3 Go Next");
            await _navigation.navigateToAsync(NavigationService.Page3, false);
        }
    }
}