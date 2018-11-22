using DotNetCoreArchitecture.Model.Entities;
using DotNetCoreArchitecture.Model.Enums;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserLogFactory
    {
        UserLogEntity Create(long userId, LogType logType);
    }
}
