using System;
using ApiRepositories.Member;
using ApiRepositories.User;

namespace ApiUnitOfWork.General
{
    public interface IUnitOfWork
    {
        public IUserRepository IUser { get; set; }
        public IMemberRepository IMember { get; set; }
    }
}
