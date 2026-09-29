using MauiOpenGym.Views.Pages.Startup;
using Microsoft.Extensions.DependencyInjection;

namespace MauiOpenGym
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartupPage();
        }
    }
}