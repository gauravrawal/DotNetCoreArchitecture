using DotNetCore.Repositories;
using DotNetCoreArchitecture.Model.Entities;
using DotNetCoreArchitecture.Model.Models;

namespace DotNetCoreArchitecture.Database
{
    public interface IUserRepository : IRelationalRepository<UserEntity>
    {
        SignedInModel SignIn(SignInModel signIn);
    }
}
