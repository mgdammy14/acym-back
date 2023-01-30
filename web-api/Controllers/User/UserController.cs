using System;
using ApiBusinessLogic.Interfaces.User;
using ApiModel.RequestDTO.User;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers.User
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IUserLogic _logic;
        public UserController(IUserLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetUsers());
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserRequest dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.CreateUser(dto));
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
