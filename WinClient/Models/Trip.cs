using Application.Tickets.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClient.ModelWrappers
{
    internal class Trip
    {
        private readonly TripDto model;

        public Trip(TripDto tripDto)
        {
            model = tripDto;
        }

        public string From 
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

        public string To { get; set; }
    }
}
