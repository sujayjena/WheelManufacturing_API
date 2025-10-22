using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Helpers;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingDetailsController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IShippingDetailsRepository _shippingDetailsRepository;
        private IFileManager _fileManager;

        public ShippingDetailsController(IShippingDetailsRepository shippingDetailsRepository, IFileManager fileManager)
        {
            _shippingDetailsRepository = shippingDetailsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveShippingDetails(ShippingDetails_Request parameters)
        {
            int result = await _shippingDetailsRepository.SaveShippingDetails(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record is already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";
            }
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetShippingDetailsList(Search_Request parameters)
        {
            IEnumerable<ShippingDetails_Response> lstCustomers = await _shippingDetailsRepository.GetShippingDetailsList(parameters);
            _response.Data = lstCustomers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetShippingDetailsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _shippingDetailsRepository.GetShippingDetailsById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
