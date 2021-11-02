using Application.Tickets.DTO;
using System;
using System.ComponentModel.DataAnnotations;
using WinClient.Common;
using WinClient.NTier.Common;

namespace WinClient.NTier.Models
{
    public class Trip : DtoWrapper<TripDto>
    {
        public Trip(TripDto tripDto) : base(tripDto)
        {  
        
        }

        [Required]
        public string From 
        {
            get => GetValue<string>();
        }

        [Required]
        public string To 
        {
            get => GetValue<string>();
        }
    }
}
