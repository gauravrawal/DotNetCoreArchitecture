using DotNetCore.AspNetCore;
using DotNetCore.Extensions;
using DotNetCoreArchitecture.Application;
using DotNetCoreArchitecture.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreArchitecture.Web
{
    [ApiController]
    [RouteController]
    public class AuthenticationController : ControllerBase
    {
        public AuthenticationController(IAuthenticationApplication authenticationApplication)
        {
            AuthenticationApplication = authenticationApplication;
        }

        private IAuthenticationApplication AuthenticationApplication { get; }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public string SignIn(SignInModel signIn)
        {
            return AuthenticationApplication.SignIn(signIn);
        }

        [HttpPost("[action]")]
        public void SignOut()
        {
            var signOut = new SignOutModel(User.ClaimNameIdentifierValue());
            AuthenticationApplication.SignOut(signOut);
        }
    }
}
