using System;
using System.Collections.Generic;
using ApiModel.Maintenance;

namespace ApiBusinessLogic.Interfaces.Maintenance
{
    public interface ITypeIncomeLogic
    {
        public IEnumerable<TypeIncome> GetTypeIncomeList();
        public int CreateTypeIncome(TypeIncome dto);
        public bool UpdateTypeIncome(TypeIncome dto);
        public bool DeleteTypeIncome(int idTypeIncome);
    }
}
