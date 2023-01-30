using System;
using ApiModel.RequestDTO.Login;
using ApiModel.ResponseDTO.Login;
using ApiModel.User;

namespace ApiBusinessLogic.Interfaces.General
{
    public interface ILoginLogic
    {
        public LoginResponse Login(LoginRequest dto);
    }
}
