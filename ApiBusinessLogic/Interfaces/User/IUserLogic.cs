using System;
using System.Collections.Generic;
using ApiModel.RequestDTO.User;
using ApiModel.User;

namespace ApiBusinessLogic.Interfaces.User
{
    public interface IUserLogic
    {
        public List<Users> GetUsers();
        public int CreateUser(UserRequest dto);
    }
}
