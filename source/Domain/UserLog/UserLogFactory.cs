using DotNetCoreArchitecture.Model.Entities;
using DotNetCoreArchitecture.Model.Enums;
using System;

namespace DotNetCoreArchitecture.Domain
{
    public class UserLogFactory : IUserLogFactory
    {
        public UserLogEntity Create(long userId, LogType logType)
        {
            return new UserLogEntity
            {
                UserId = userId,
                LogType = logType,
                DateTime = DateTime.UtcNow
            };
        }
    }
}
