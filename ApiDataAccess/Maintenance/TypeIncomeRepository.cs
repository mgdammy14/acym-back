using System;
using ApiDataAccess.General;
using ApiModel.Maintenance;
using ApiRepositories.Maintenance;

namespace ApiDataAccess.Maintenance
{
    public class TypeIncomeRepository : Repository<TypeIncome> , ITypeIncomeRepository
    {
        public TypeIncomeRepository(string connectionsString) : base(connectionsString)
        {
        }
    }
}
