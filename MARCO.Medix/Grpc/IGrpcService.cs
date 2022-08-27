using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Grpc
{
    public interface IGrpcService
    {
        public IHttpContextAccessor HttpContextAccessor { get; }
    }

    public static class Extention
    {
        public static string JwtToken(this IGrpcService grpcService)
        {
            var token = grpcService.HttpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            return token != null ? token.Replace("Bearer ", "") : null;
        }
        public static IdentityUser User(this IGrpcService grpcService)
        {
            IdentityUser user = new IdentityUser();
            user.Id = grpcService.HttpContextAccessor?.HttpContext?.User?.Claims?.Where(u => u.Type == ClaimTypes.NameIdentifier).FirstOrDefault()?.Value;
            user.UserName = grpcService.HttpContextAccessor?.HttpContext?.User?.Claims?.Where(u => u.Type == "preferred_username").FirstOrDefault()?.Value;
            user.Email = grpcService.HttpContextAccessor?.HttpContext?.User?.Claims?.Where(u => u.Type == ClaimTypes.Email).FirstOrDefault()?.Value;

            return user;
        }

    }
}
