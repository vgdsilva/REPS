using TrainingApp.Views.Pages.Startup;
using Microsoft.Extensions.DependencyInjection;

namespace TrainingApp
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
