using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Helpers;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;
using WheelManufacturing.Persistence.Repositories;

namespace WheelManufacturing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagePurchaseRequisitionController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IManagePurchaseRequisitionRepository _managePurchaseRequisitionRepository;
        private IFileManager _fileManager;

        public ManagePurchaseRequisitionController(IManagePurchaseRequisitionRepository managePurchaseRequisitionRepository, IFileManager fileManager)
        {
            _managePurchaseRequisitionRepository = managePurchaseRequisitionRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SavePurchaseRequisition(PurchaseRequisition_Request parameters)
        {
            int result = await _managePurchaseRequisitionRepository.SavePurchaseRequisition(parameters);

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
                _response.Message = "Record details saved successfully";

                //purchase requisition details
                if (result > 0)
                {
                    foreach (var item in parameters.purchaseRequisitionDetails)
                    {
                        item.PurchaseRequisitionId = result;
                        int detailsResult = await _managePurchaseRequisitionRepository.SavePurchaseRequisitionDetails(item);
                    }
                }
            }

            _response.Id = result;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPurchaseRequisitionList(PurchaseRequisition_Search parameters)
        {
            IEnumerable<PurchaseRequisitionList_Response> lstRoles = await _managePurchaseRequisitionRepository.GetPurchaseRequisitionList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPurchaseRequisitionById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _managePurchaseRequisitionRepository.GetPurchaseRequisitionById(Id);
                if(vResultObj != null)
                {
                    var vPurchaseRequisitionDetails_Search = new PurchaseRequisitionDetails_Search()
                    {
                        PurchaseRequisitionId = vResultObj.Id
                    };
                    var vPurchaseRequisitionDetails = await _managePurchaseRequisitionRepository.GetPurchaseRequisitionDetailsList(vPurchaseRequisitionDetails_Search);
                    vResultObj.purchaseRequisitionDetails = vPurchaseRequisitionDetails.ToList();
                }
                _response.Data = vResultObj;
            }
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> PurchaseRequisitionApproveNReject(PurchaseRequisition_ApproveNReject parameters)
        {
            if (parameters.Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                int resultExpenseDetails = await _managePurchaseRequisitionRepository.PurchaseRequisitionApproveNReject(parameters);

                if (resultExpenseDetails == (int)SaveOperationEnums.NoRecordExists)
                {
                    _response.Message = "No record exists";
                }
                else if (resultExpenseDetails == (int)SaveOperationEnums.ReocrdExists)
                {
                    _response.Message = "Record already exists";
                }
                else if (resultExpenseDetails == (int)SaveOperationEnums.NoResult)
                {
                    _response.Message = "Something went wrong, please try again";
                }
                else
                {
                    if (parameters.StatusId == 2)
                    {
                        _response.Message = "Record Approved successfully";
                    }
                    else if (parameters.StatusId == 3)
                    {
                        _response.Message = "Record Rejected successfully";
                    }
                }
            }

            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPurchaseRequisitionApproveNRejectHistoryListById(PurchaseRequisitionApproveNRejectHistory_Search parameters)
        {
            IEnumerable<PurchaseRequisitionApproveNRejectHistory_Response> lstObj = await _managePurchaseRequisitionRepository.GetPurchaseRequisitionApproveNRejectHistoryListById(parameters);
            _response.Data = lstObj.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> DeletePurchaseRequisitionDetails(int Id)
        {
            int result = await _managePurchaseRequisitionRepository.DeletePurchaseRequisitionDetails(Id);

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
                _response.Message = "Record deleted successfully";
            }

            _response.Id = result;
            return _response;
        }
    }
}

