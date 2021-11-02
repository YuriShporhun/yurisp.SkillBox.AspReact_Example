using System;
using System.Runtime.CompilerServices;
using WinClient.Common;

namespace WinClient.NTier.Common
{
    public class DtoWrapper<TDto> : Bindable
    {
        protected TDto dto;

        public DtoWrapper(TDto Dto)
        {
            if(Dto == null)
            {
                throw new ArgumentNullException($"Dto типа {typeof(TDto).Name}");
            }
            dto = Dto;
        }

        protected void SetValue<TValue>(TValue value, [CallerMemberName] string propertyName=null)
        {
            var propertyInfo = dto.GetType().GetProperty(propertyName);
            var propertyValue = propertyInfo.GetValue(dto, null);
            if (!Equals(propertyValue, value))
            {
                propertyInfo.SetValue(dto, value, null);
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
