﻿namespace MauiMemory.Services
{
    public interface INavigationService
    {
        Task navigateToAsync(string route, bool clearStack = true);
    }
}
