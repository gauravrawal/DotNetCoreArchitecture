using DotNetCoreArchitecture.Database;
using DotNetCoreArchitecture.Model.Enums;

namespace DotNetCoreArchitecture.Domain
{
    public sealed class UserLogDomain : IUserLogDomain
    {
        public UserLogDomain(
            IDatabaseUnitOfWork databaseUnitOfWork,
            IUserLogFactory userLogFactory)
        {
            DatabaseUnitOfWork = databaseUnitOfWork;
            UserLogFactory = userLogFactory;
        }

        private IDatabaseUnitOfWork DatabaseUnitOfWork { get; }
        private IUserLogFactory UserLogFactory { get; }

        public void Save(long userId, LogType logType)
        {
            var userLog = UserLogFactory.Create(userId, logType);
            DatabaseUnitOfWork.UserLogRepository.Add(userLog);
            DatabaseUnitOfWork.SaveChanges();
        }
    }
}
