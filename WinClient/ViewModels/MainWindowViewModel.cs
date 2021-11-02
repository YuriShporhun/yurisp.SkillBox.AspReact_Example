using WinClient.Common;

namespace WinClient.ViewModels
{
    internal class MainWindowViewModel : Bindable
    {
        public Bindable CurrentViewModel { get; set; } = new  HomeViewModel();
    }
}
