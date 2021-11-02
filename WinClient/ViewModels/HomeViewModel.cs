using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WinClient.Commands;
using WinClient.Common;

namespace WinClient.ViewModels
{
    public class HomeViewModel : Bindable
    {
        ICommand LoginCommand;

        public string Email { get; set; }
        public string Password { get; set; }

        public HomeViewModel()
        {
            InitCommands();
        }

        private void InitCommands()
        {
            LoginCommand = new RelayCommand(LoginExecute, CanLoginExecute);
        }

        void LoginExecute(object parameter)
        {

        }

        bool CanLoginExecute(object parameter)
        {
            return true;
        }
    }
}
