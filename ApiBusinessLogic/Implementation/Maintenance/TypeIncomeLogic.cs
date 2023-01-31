using System;
using System.Collections.Generic;
using ApiBusinessLogic.Interfaces.General;
using ApiBusinessLogic.Interfaces.Maintenance;
using ApiModel.Maintenance;
using ApiUnitOfWork.General;

namespace ApiBusinessLogic.Implementation.Maintenance
{
    public class TypeIncomeLogic : ITypeIncomeLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        private IExceptionCustomizedLogic _logicExceptionCustomizedLogic;
        private string _option;

        public TypeIncomeLogic(IUnitOfWork unitOfWork, IExceptionCustomizedLogic exceptionCustomizedLogic)
        {
            _unitOfWork = unitOfWork;
            _logicExceptionCustomizedLogic = exceptionCustomizedLogic;
            _option = "TypeIncome";
        }

        public IEnumerable<TypeIncome> GetTypeIncomeList()
        {
            try
            {
                return _unitOfWork.ITypeIncome.GetList();
            }
            catch(Exception e)
            {
                throw _logicExceptionCustomizedLogic.Decision(_option, e);
            }
        }

        public int CreateTypeIncome(TypeIncome dto)
        {
            try
            {
                return _unitOfWork.ITypeIncome.Insert(dto);
            }
            catch(Exception e)
            {
                throw _logicExceptionCustomizedLogic.Decision(_option, e);
            }
        }

        public bool UpdateTypeIncome(TypeIncome dto)
        {
            try
            {
                return _unitOfWork.ITypeIncome.Update(dto);
            }
            catch(Exception e)
            {
                throw _logicExceptionCustomizedLogic.Decision(_option, e);
            }
        }

        public bool DeleteTypeIncome(int idTypeIncome)
        {
            try
            {
                TypeIncome dto = new TypeIncome();
                dto.idTypeIncome = idTypeIncome;
                return _unitOfWork.ITypeIncome.Delete(dto);
            }
            catch(Exception e)
            {
                throw _logicExceptionCustomizedLogic.Decision(_option, e);
            }
        }
    }
}
