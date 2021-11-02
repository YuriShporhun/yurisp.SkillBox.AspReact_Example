﻿using Application.User.Dto;
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
            get => GetValue<string>();  
            set => SetValue(dto.DisplayName, value);
        }
    }
}
