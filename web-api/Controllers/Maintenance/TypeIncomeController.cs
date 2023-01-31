using System;
using ApiBusinessLogic.Interfaces.Maintenance;
using ApiModel.Maintenance;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers.Maintenance
{
    [Route("api/typeIncome")]
    public class TypeIncomeController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private ITypeIncomeLogic _logic;

        public TypeIncomeController(ITypeIncomeLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetTypeIncomes()
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetTypeIncomeList());
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult CreateTypeIncome([FromBody] TypeIncome dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.CreateTypeIncome(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPut]
        public IActionResult UpdateTypeIncome([FromBody] TypeIncome dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.UpdateTypeIncome(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpDelete]
        [Route("{idTypeIncome:int}")]
        public IActionResult UpdateMember(int idTypeIncome)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.DeleteTypeIncome(idTypeIncome));
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
