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
    public class BillingDetailsController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IBillingDetailsRepository _billingDetailsRepository;
        private IFileManager _fileManager;

        public BillingDetailsController(IBillingDetailsRepository billingDetailsRepository, IFileManager fileManager)
        {
            _billingDetailsRepository = billingDetailsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveBillingDetails(BillingDetails_Request parameters)
        {
            //GST Upload
            if (parameters != null && !string.IsNullOrWhiteSpace(parameters.GST_Base64))
            {
                var vUploadFile = _fileManager.UploadDocumentsBase64ToFile(parameters.GST_Base64, "\\Uploads\\BillingDetails\\", parameters.GSTOriginalFileName);

                if (!string.IsNullOrWhiteSpace(vUploadFile))
                {
                    parameters.GSTFileName = vUploadFile;
                }
            }

            int result = await _billingDetailsRepository.SaveBillingDetails(parameters);

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
        public async Task<ResponseModel> GetBillingDetailsList(Search_Request parameters)
        {
            IEnumerable<BillingDetails_Response> lstCustomers = await _billingDetailsRepository.GetBillingDetailsList(parameters);
            _response.Data = lstCustomers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetBillingDetailsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _billingDetailsRepository.GetBillingDetailsById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
