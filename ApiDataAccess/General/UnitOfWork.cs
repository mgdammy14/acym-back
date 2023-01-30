using System;
using ApiDataAccess.Member;
using ApiDataAccess.User;
using ApiRepositories.User;
using ApiRepositories.Member;
using ApiUnitOfWork.General;

namespace ApiDataAccess.General
{
    public class UnitOfWork: IUnitOfWork
    {
        public IUserRepository IUser { get; set; }
        public IMemberRepository IMember { get; set; }

        public UnitOfWork(string connectionString)
        {
            IUser = new UserRepository(connectionString);
            IMember = new MemberRepository(connectionString);
        }
    }
}
