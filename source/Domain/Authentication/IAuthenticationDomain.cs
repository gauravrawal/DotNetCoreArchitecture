using DotNetCoreArchitecture.Model.Models;

namespace DotNetCoreArchitecture.Domain
{
    public interface IAuthenticationDomain
    {
        string SignIn(SignInModel signIn);

        void SignOut(SignOutModel signOut);
    }
}
