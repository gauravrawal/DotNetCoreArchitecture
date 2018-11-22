using DotNetCoreArchitecture.Model.Enums;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserLogDomain
    {
        void Save(long userId, LogType logType);
    }
}
