using DotNetCore.EntityFrameworkCore;
using DotNetCoreArchitecture.Model.Entities;
using DotNetCoreArchitecture.Model.Enums;
using DotNetCoreArchitecture.Model.Models;

namespace DotNetCoreArchitecture.Database
{
    public sealed class UserRepository : EntityFrameworkCoreRepository<UserEntity>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }

        public SignedInModel SignIn(SignInModel signIn)
        {
            return SingleOrDefault<SignedInModel>
            (
                user => user.Login.Equals(signIn.Login)
                && user.Password.Equals(signIn.Password)
                && user.Status == Status.Active
            );
        }
    }
}
