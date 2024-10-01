using FurniFusion_E_Commerce_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FurniFusion_E_Commerce_.Controllers
{
    [Authorize(Roles = "superAdmin, moderator")]
    [ApiController]
    [Route(("api/[controller]"))]
    public class ModeratorController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public ModeratorController(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }
    }
}
