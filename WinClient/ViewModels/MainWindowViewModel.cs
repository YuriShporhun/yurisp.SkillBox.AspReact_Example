using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinClient.Common;

namespace WinClient.ViewModels
{
    internal class MainWindowViewModel
    {
        public Bindable CurrentViewModel { get; set; } = new  HomeViewModel();
    }
}
