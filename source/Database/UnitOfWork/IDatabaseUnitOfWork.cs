namespace DotNetCoreArchitecture.Database
{
    public interface IDatabaseUnitOfWork
    {
        IUserLogRepository UserLogRepository { get; }

        IUserRepository UserRepository { get; }

        void SaveChanges();
    }
}
