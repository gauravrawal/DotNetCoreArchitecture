using DotNetCore.Objects;
using DotNetCoreArchitecture.Domain;
using DotNetCoreArchitecture.Model.Models;
using System.Collections.Generic;

namespace DotNetCoreArchitecture.Application
{
    public sealed class UserApplication : IUserApplication
    {
        public UserApplication(IUserDomain userDomain)
        {
            UserDomain = userDomain;
        }

        private IUserDomain UserDomain { get; }

        public PagedList<UserModel> List(PagedListParameters parameters)
        {
            return UserDomain.List(parameters);
        }

        public IEnumerable<UserModel> List()
        {
            return UserDomain.List();
        }

        public UserModel Select(long userId)
        {
            return UserDomain.Select(userId);
        }
    }
}
