using System;
using System.Collections.Generic;
using System.Linq;
using ApiBusinessLogic.Interfaces.Member;
using ApiModel.Member;
using ApiModel.RequestDTO.Member;
using ApiUnitOfWork.General;

namespace ApiBusinessLogic.Implementation.Member
{
    public class MemberLogic : IMemberLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Members> GetMembers()
        {
            try
            {
                return _unitOfWork.IMember.GetList().ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int CreateMember(MemberRequest dto)
        {
            try
            {
                Members obj = new Members();
                return _unitOfWork.IMember.Insert(obj.Mapper(obj, dto));
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool UpdateMember(Members dto)
        {
            try
            {
                return _unitOfWork.IMember.Update(dto);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
