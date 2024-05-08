namespace MauiMemory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.Page4();// new AppShell();
        }
    }
}
