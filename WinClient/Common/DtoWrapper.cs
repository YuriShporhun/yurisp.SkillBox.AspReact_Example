using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WinClient.NTier.Common
{
    public class DtoWrapper<TDto> : NotifyErrorInfo
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

        protected void SetValue<TValue>(TValue value, [CallerMemberName] string propertyName = null)
        {
            var propertyInfo = dto.GetType().GetProperty(propertyName);
            var propertyValue = propertyInfo.GetValue(dto, null);
            if (!Equals(propertyValue, value))
            {
                propertyInfo.SetValue(dto, value, null);
                VadidateProperty(propertyName, propertyValue);
                RaisePropertyChanged(propertyName);
            }
        }

        private void VadidateProperty(string propertyName, object propertyValue)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(this)
            {
                MemberName = propertyName,
            };
            Validator.TryValidateProperty(propertyValue, context, validationResults);
            if(validationResults.Any())
            {
                Errors[propertyName] = validationResults.Select(x => x.ErrorMessage).Distinct().ToList();
                RaiseErrorChanged(propertyName);
            }
            else
            {
                if(Errors.ContainsKey(propertyName))
                {
                    Errors.Remove(propertyName);
                    RaiseErrorChanged(propertyName);
                }
            }
        }

        protected TValue GetValue<TValue>([CallerMemberName] string propertyName = null)
        {
            var propertyInfo = dto.GetType().GetProperty(propertyName);
            var propertyValue = propertyInfo?.GetValue(dto, null);
            return (TValue)propertyValue;
        }
    }
}
