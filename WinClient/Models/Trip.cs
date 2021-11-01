using Application.Tickets.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClient.NTier.Models
{
    public class Trip
    {
        public readonly TripDto model;

        public Trip(TripDto tripDto)
        {
            model = tripDto ?? throw new ArgumentNullException(nameof(tripDto));
        }

        public string LeavingFrom 
        { 
            get
            {
                return model.From;
            }
            set
            {
                model.From = value;
            }
        }

        public string GoingTo 
        { 
            get
            {
                return model.To;
            }
            set
            {
                model.To = value;
            }
        }
    }
}
