using DotNetCoreArchitecture.Model.Models;

namespace DotNetCoreArchitecture.Application
{
    public interface IAuthenticationApplication
    {
        string SignIn(SignInModel signIn);

        void SignOut(SignOutModel signOut);
    }
}
