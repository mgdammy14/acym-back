using System;
using System.Collections.Generic;
using System.Linq;
using ApiBusinessLogic.Interfaces.User;
using ApiModel.RequestDTO.User;
using ApiModel.User;
using ApiUnitOfWork.General;

namespace ApiBusinessLogic.Implementation.User
{
    public class UserLogic : IUserLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Users> GetUsers()
        {
            try
            {
                return _unitOfWork.IUser.GetList().ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int CreateUser(UserRequest dto)
        {
            try
            {
                Users obj = new Users();
                return _unitOfWork.IUser.Insert(obj.Mapper(obj, dto));
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
