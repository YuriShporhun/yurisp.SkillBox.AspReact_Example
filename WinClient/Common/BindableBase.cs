using System.ComponentModel;

namespace WinClient.Common
{
    internal class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
