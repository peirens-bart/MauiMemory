

namespace MauiMemory.Services
{
    public class NavigationService : INavigationService
    {
        internal const string Home = "home";
        internal const string Page1 = "page1";
        internal const string Page2 = "page2";
        private readonly IServiceProvider _services;

        public NavigationService(IServiceProvider service)
        {
            _services = service;
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute(Home, typeof(MainPage));
            Routing.RegisterRoute(Page1, typeof(Pages.Page1));
            Routing.RegisterRoute(Page2, typeof(Pages.Page2));
        }

        public void ClearStack()
        {
            var stack = Shell.Current.Navigation.NavigationStack.ToArray();
            for (int i = stack.Length - 1; i > 0; i--)
            {
                var page = stack[i];
                Shell.Current.Navigation.RemovePage(page);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public async Task navigateToAsync(string route)
        {
            ClearStack();
            await Shell.Current.GoToAsync(route, false);

        }
    }
}
