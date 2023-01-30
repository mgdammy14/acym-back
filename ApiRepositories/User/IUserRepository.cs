using System;
using ApiModel.User;
using ApiRepositories.General;

namespace ApiRepositories.User
{
    public interface IUserRepository : IRepository<Users>
    {
        public Users ValidateUsername(string username);
    }
}
