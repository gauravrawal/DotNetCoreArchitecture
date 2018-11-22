using DotNetCoreArchitecture.Domain;
using DotNetCoreArchitecture.Model.Models;

namespace DotNetCoreArchitecture.Application
{
    public sealed class AuthenticationApplication : IAuthenticationApplication
    {
        public AuthenticationApplication(IAuthenticationDomain authenticationDomain)
        {
            AuthenticationDomain = authenticationDomain;
        }

        private IAuthenticationDomain AuthenticationDomain { get; }

        public string SignIn(SignInModel signIn)
        {
            return AuthenticationDomain.SignIn(signIn);
        }

        public void SignOut(SignOutModel signOut)
        {
            AuthenticationDomain.SignOut(signOut);
        }
    }
}
