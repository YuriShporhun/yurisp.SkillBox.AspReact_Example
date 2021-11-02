using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinClient.Common;

namespace WinClient.NTier.Common
{
    public class NotifyErrorInfo : Bindable, INotifyDataErrorInfo
    {
        protected readonly Dictionary<string, List<string>> Errors;
        public bool HasErrors => throw new NotImplementedException();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
