﻿using Application.User.Dto;
using AutoMapper;
using Domain;
using Infrastructure.Identity;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Trip, Trip>();
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}
