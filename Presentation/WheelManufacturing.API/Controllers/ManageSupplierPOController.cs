using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Helpers;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.API.Controllers
{
    public class ManageSupplierPOController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IManageSupplierPORepository _manageSupplierPORepository;
        private IFileManager _fileManager;

        public ManageSupplierPOController(IManageSupplierPORepository manageSupplierPORepository, IFileManager fileManager)
        {
            _manageSupplierPORepository = manageSupplierPORepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        #region ManageSupplierPO 

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveManageSupplierPO(SupplierPO_Request parameters)
        {
            int result = await _manageSupplierPORepository.SaveSupplierPO(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record already exists";
            }
            else if (result == -3)
            {
                _response.Message = "Email already exists";
            }
            else if (result == -4)
            {
                _response.Message = "Mobile # already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                if (parameters.Id == 0)
                {
                    _response.Message = "Record Submitted successfully";
                }
                else
                {
                    _response.Message = "Record Updated successfully";
                }

                foreach (var item in parameters.supplierPODetailsList)
                {
                    item.SupplierPOId = result;

                    int resultManageSupplierPODetails = await _manageSupplierPORepository.SaveSupplierPODetails(item);
                }
            }

            _response.Id = result;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetManageSupplierPOList(SupplierPO_Search parameters)
        {
            IEnumerable<SupplierPOList_Response> lstManageSupplierPOs = await _manageSupplierPORepository.GetSupplierPOList(parameters);
            _response.Data = lstManageSupplierPOs.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetManageSupplierPOById(int Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _manageSupplierPORepository.GetSupplierPOById(Id);
                if (vResultObj != null)
                {
                    var vManageSupplierPODetails_Search = new SupplierPODetails_Search();
                    vManageSupplierPODetails_Search.SupplierPOId = vResultObj.Id;

                    var vList = await _manageSupplierPORepository.GetSupplierPODetailsList(vManageSupplierPODetails_Search);

                    vResultObj.supplierPODetailsList = vList.ToList();
                }
                _response.Data = vResultObj;
            }
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> DeleteSupplierPODetails(int Id)
        {
            int result = await _manageSupplierPORepository.DeleteSupplierPODetails(Id);

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
        #endregion
    }
}
