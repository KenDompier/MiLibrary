using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MediaLibraryGraphicalDesktopApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _window;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _window = new MainWindow();
            _window.Show();
        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            _window.ViewModel.SaveMedia();
        }

    }
}
