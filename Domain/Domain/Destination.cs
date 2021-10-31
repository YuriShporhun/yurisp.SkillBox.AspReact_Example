using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain
{
    public class Destination : IEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
