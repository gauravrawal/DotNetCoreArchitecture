using DotNetCore.Objects;
using DotNetCoreArchitecture.Model.Models;
using System.Collections.Generic;

namespace DotNetCoreArchitecture.Application
{
    public interface IUserApplication
    {
        PagedList<UserModel> List(PagedListParameters parameters);

        IEnumerable<UserModel> List();

        UserModel Select(long userId);
    }
}
