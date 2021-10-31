using Application.User;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpPost("login")]
        public async Task<ActionResult<ApplicationUser>> Login(Login.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
