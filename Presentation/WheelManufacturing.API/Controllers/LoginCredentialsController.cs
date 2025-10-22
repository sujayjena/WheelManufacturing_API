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
    public class LoginCredentialsController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly ILoginCredentialsRepository _loginCredentialsRepository;
        private IFileManager _fileManager;

        public LoginCredentialsController(ILoginCredentialsRepository loginCredentialsRepository, IFileManager fileManager)
        {
            _loginCredentialsRepository = loginCredentialsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveLoginCredentials(LoginCredentials_Request parameters)
        {
            int result = await _loginCredentialsRepository.SaveLoginCredentials(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Mobile Number is exists";
                //_response.Message = "Record is already exists";
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
        public async Task<ResponseModel> GetLoginCredentialsList(Search_Request parameters)
        {
            IEnumerable<LoginCredentials_Response> lstCustomers = await _loginCredentialsRepository.GetLoginCredentialsList(parameters);
            _response.Data = lstCustomers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetLoginCredentialsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _loginCredentialsRepository.GetLoginCredentialsById(Id);
                if (vResultObj != null)
                {
                    vResultObj.Passwords = !string.IsNullOrWhiteSpace(vResultObj.Passwords) ? EncryptDecryptHelper.DecryptString(vResultObj.Passwords) : string.Empty;
                }

                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
