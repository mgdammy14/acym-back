using System;
using ApiBusinessLogic.Interfaces.General;
using ApiModel.RequestDTO.Login;
using ApiModel.ResponseDTO.General;
using ApiModel.User;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers.Login
{
    [Route("api/login")]
    public class LoginController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private ILoginLogic _logic;
        public LoginController(ILoginLogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.Login(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }
    }
}
