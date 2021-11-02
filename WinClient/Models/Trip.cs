using Application.Tickets.DTO;
using System;
using WinClient.Common;
using WinClient.NTier.Common;

namespace WinClient.NTier.Models
{
    public class Trip : DtoWrapper<TripDto>
    {
        public Trip(TripDto tripDto) : base(tripDto)
        {  
        
        }

        public string LeavingFrom 
        { 
            get
            {
                return dto.From;
            }
        }

        public string GoingTo 
        { 
            get
            {
                return dto.To;
            }
        }
    }
}
