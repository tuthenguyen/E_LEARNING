using E_LEARNING.APPLICATION.Base.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace E_LEARNING.WEBAPI.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public int? Id
        {
            get
            {
                var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                if (int.TryParse(userIdClaim, out var id))
                {
                    return id;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
