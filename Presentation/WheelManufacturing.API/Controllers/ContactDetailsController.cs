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
    public class ContactDetailsController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IContactDetailsRepository _contactDetailsRepository;
        private IFileManager _fileManager;

        public ContactDetailsController(IContactDetailsRepository contactDetailsRepository, IFileManager fileManager)
        {
            _contactDetailsRepository = contactDetailsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveContactDetails(ContactDetails_Request parameters)
        {
            int result = await _contactDetailsRepository.SaveContactDetails(parameters);

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
            else if (result == -3)
            {
                _response.Message = "Mobile Number is exists";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";
            }

            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetContactDetailsList(Search_Request parameters)
        {
            IEnumerable<ContactDetails_Response> lstCustomers = await _contactDetailsRepository.GetContactDetailsList(parameters);
            _response.Data = lstCustomers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetContactDetailsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _contactDetailsRepository.GetContactDetailsById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
