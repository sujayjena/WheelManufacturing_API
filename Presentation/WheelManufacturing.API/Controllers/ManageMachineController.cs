using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageMachineController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IManageMachineRepository _manageMachineRepository;

        public ManageMachineController(IManageMachineRepository manageMachineRepository)
        {
            _manageMachineRepository = manageMachineRepository;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        #region Machine Assign

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveMachineAssign(List<MachineAssign_Request> parameters)
        {
            int result = 0;
            foreach (var items in parameters)
            {
                result = await _manageMachineRepository.SaveMachineAssign(items);
            }

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                if (parameters.ToList().FirstOrDefault().Id == 0)
                {
                    _response.Message = "Record details saved successfully";
                }
                else
                {
                    _response.Message = "Record details Updated successfully";
                }
            }

            _response.Id = result;
            return _response;

        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMachineAssignList(MachineAssign_Search parameters)
        {
            var objList = await _manageMachineRepository.GetMachineAssignList(parameters);
            _response.Data = objList.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMachineListForAssignOperator(MachineListForAssignOperator_Search parameters)
        {
            var objList = await _manageMachineRepository.GetMachineListForAssignOperator(parameters);
            _response.Data = objList.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        //[Route("[action]")]
        //[HttpPost]
        //public async Task<ResponseModel> GetOperatorNameForSelectList(OperatorNameSelectList_Search parameters)
        //{
        //    IEnumerable<OperatorNameSelectList_Response> lstResponse = await _manageMachineRepository.GetOperatorNameForSelectList(parameters);
        //    _response.Data = lstResponse.ToList();
        //    return _response;
        //}
        #endregion
    }
}
