using Infrastructure.Identity;

namespace Application.Jwt.Interfaces
{
    public interface IJwtService
    {
        string CreateToken(ApplicationUser applicationUser);
    }
}
