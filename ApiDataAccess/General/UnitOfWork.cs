using System;
using ApiDataAccess.Member;
using ApiDataAccess.User;
using ApiRepositories.User;
using ApiRepositories.Member;
using ApiUnitOfWork.General;
using ApiRepositories.Maintenance;
using ApiDataAccess.Maintenance;

namespace ApiDataAccess.General
{
    public class UnitOfWork: IUnitOfWork
    {
        public IUserRepository IUser { get; set; }
        public IMemberRepository IMember { get; set; }
        public ITypeIncomeRepository ITypeIncome { get; set; }

        public UnitOfWork(string connectionString)
        {
            IUser = new UserRepository(connectionString);
            IMember = new MemberRepository(connectionString);
            ITypeIncome = new TypeIncomeRepository(connectionString);
        }
    }
}
