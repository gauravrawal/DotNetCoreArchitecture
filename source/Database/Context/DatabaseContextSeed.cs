using DotNetCore.Security;
using DotNetCoreArchitecture.Model.Entities;
using DotNetCoreArchitecture.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreArchitecture.Database
{
    public static class DatabaseContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var hash = new Hash();

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                UserId = 1,
                Name = "Administrator",
                Surname = "Administrator",
                Email = "administrator@administrator.com",
                Login = hash.Create("admin"),
                Password = hash.Create("admin"),
                Roles = Roles.User | Roles.Admin,
                Status = Status.Active
            });
        }
    }
}
