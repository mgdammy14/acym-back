using System;
using ApiRepositories.Maintenance;
using ApiRepositories.Member;
using ApiRepositories.User;

namespace ApiUnitOfWork.General
{
    public interface IUnitOfWork
    {
        public IUserRepository IUser { get; set; }
        public IMemberRepository IMember { get; set; }
        public ITypeIncomeRepository ITypeIncome { get; set; }
    }
}
