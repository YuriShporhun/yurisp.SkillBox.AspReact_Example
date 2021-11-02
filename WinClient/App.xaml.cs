using WinClient.ViewModels;
using WinApp = System.Windows.Application;

namespace WinClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : WinApp
    {
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.DataContext = new MainWindowViewModel();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
