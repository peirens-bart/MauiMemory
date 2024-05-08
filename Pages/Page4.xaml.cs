namespace MauiMemory.Pages;

public partial class Page4 : ContentPage
{
    private Timer? _timer;
    public Page4()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        _timer = new Timer(callback =>
        {
            Dispatcher.Dispatch(() =>
            {
                Blinker.IsVisible = !Blinker.IsVisible;
            });
        }, null, 0, 1000);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _timer?.Dispose();
    }
}