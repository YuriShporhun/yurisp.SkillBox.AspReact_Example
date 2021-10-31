using Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Jwt.Interfaces
{
    public interface IJwtService
    {
        string Create(ApplicationUser applicationUser);
    }
}
