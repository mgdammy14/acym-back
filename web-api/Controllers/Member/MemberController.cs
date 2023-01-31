using System;
using ApiBusinessLogic.Interfaces.Member;
using ApiModel.Member;
using ApiModel.RequestDTO.Member;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers.Member
{
    [Route("api/member")]
    public class MemberController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IMemberLogic _logic;

        public MemberController(IMemberLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetMembers()
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetMembers());
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult CreateMember([FromBody] MemberRequest dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.CreateMember(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPut]
        public IActionResult UpdateMember([FromBody] Members dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.UpdateMember(dto));
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
