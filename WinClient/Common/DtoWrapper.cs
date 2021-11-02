using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinClient.Common;

namespace WinClient.NTier.Common
{
    public class DtoWrapper<T> : Bindable
    {
        protected T dto;
        public DtoWrapper(T Dto)
        {
            if(Dto == null)
            {
                throw new ArgumentNullException($"Dto типа {typeof(T).Name}");
            }
            dto = Dto;
        }
    }
}
