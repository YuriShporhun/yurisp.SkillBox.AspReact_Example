using Application.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinClient.Common;
using WinClient.NTier.Common;

namespace WinClient.NTier.Models
{
    public class UserInfo : DtoWrapper<UserDto>
    {
        public UserInfo(UserDto userDto) : base(userDto)
        {
            
        }

        public string DisplayName 
        { 
            get
            {
                return dto.DisplayName;
            }
            set
            {
                dto.DisplayName = value;
                RaisePropertyChanged();
            }
        }
    }
}
