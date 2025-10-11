using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;
using WheelManufacturing.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WheelManufacturing.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminMasterController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IAdminMasterRepository _adminMasterRepository;

        private readonly IConfigRefRepository _configRefRepository;

        public AdminMasterController(IAdminMasterRepository adminMasterRepository)
        {
            _adminMasterRepository = adminMasterRepository;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        #region Blood Group

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveBloodGroup(BloodGroup_Request parameters)
        {
            int result = await _adminMasterRepository.SaveBloodGroup(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetBloodGroupList(BloodGroup_Search parameters)
        {
            IEnumerable<BloodGroup_Response> lstRoles = await _adminMasterRepository.GetBloodGroupList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetBloodGroupById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetBloodGroupById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Company Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveCompanyType(CompanyType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveCompanyType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetCompanyTypeList(CompanyType_Search parameters)
        {
            IEnumerable<CompanyType_Response> lstRoles = await _adminMasterRepository.GetCompanyTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetCompanyTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetCompanyTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Customer Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveCustomerType(CustomerType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveCustomerType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetCustomerTypeList(CustomerType_Search parameters)
        {
            IEnumerable<CustomerType_Response> lstRoles = await _adminMasterRepository.GetCustomerTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetCustomerTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetCustomerTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Leave Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveLeaveType(LeaveType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveLeaveType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetLeaveTypeList(LeaveType_Search parameters)
        {
            IEnumerable<LeaveType_Response> lstRoles = await _adminMasterRepository.GetLeaveTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetLeaveTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetLeaveTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Gender

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveGender(Gender_Request parameters)
        {
            int result = await _adminMasterRepository.SaveGender(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetGenderList(Gender_Search parameters)
        {
            IEnumerable<Gender_Response> lstRoles = await _adminMasterRepository.GetGenderList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetGenderById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetGenderById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Marital Status

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveMaritalStatus(MaritalStatus_Request parameters)
        {
            int result = await _adminMasterRepository.SaveMaritalStatus(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMaritalStatusList(MaritalStatus_Search parameters)
        {
            IEnumerable<MaritalStatus_Response> lstRoles = await _adminMasterRepository.GetMaritalStatusList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMaritalStatusById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetMaritalStatusById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Expense Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveExpenseType(ExpenseType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveExpenseType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetExpenseTypeList(ExpenseType_Search parameters)
        {
            IEnumerable<ExpenseType_Response> lstRoles = await _adminMasterRepository.GetExpenseTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetExpenseTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetExpenseTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Activity Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveActivityType(ActivityType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveActivityType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetActivityTypeList(ActivityType_Search parameters)
        {
            IEnumerable<ActivityType_Response> lstRoles = await _adminMasterRepository.GetActivityTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetActivityTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetActivityTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Activity Status

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveActivityStatus(ActivityStatus_Request parameters)
        {
            int result = await _adminMasterRepository.SaveActivityStatus(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetActivityStatusList(ActivityStatus_Search parameters)
        {
            IEnumerable<ActivityStatus_Response> lstRoles = await _adminMasterRepository.GetActivityStatusList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetActivityStatusById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetActivityStatusById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Renewal Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveRenewalType(RenewalType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveRenewalType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetRenewalTypeList(RenewalType_Search parameters)
        {
            IEnumerable<RenewalType_Response> lstRoles = await _adminMasterRepository.GetRenewalTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetRenewalTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetRenewalTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Priority

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SavePriority(Priority_Request parameters)
        {
            int result = await _adminMasterRepository.SavePriority(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPriorityList(Priority_Search parameters)
        {
            IEnumerable<Priority_Response> lstRoles = await _adminMasterRepository.GetPriorityList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPriorityById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetPriorityById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Version Details

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveVersionDetails(VersionDetails_Request parameters)
        {
            int result = await _adminMasterRepository.SaveVersionDetails(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetVersionDetailsList(VersionDetails_Search parameters)
        {
            IEnumerable<VersionDetails_Response> lstRoles = await _adminMasterRepository.GetVersionDetailsList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetVersionDetailsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetVersionDetailsById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region UOM

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveUOM(UOM_Request parameters)
        {
            int result = await _adminMasterRepository.SaveUOM(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetUOMList(UOM_Search parameters)
        {
            IEnumerable<UOM_Response> lstRoles = await _adminMasterRepository.GetUOMList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetUOMById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetUOMById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Warehouse

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveWarehouse(Warehouse_Request parameters)
        {
            int result = await _adminMasterRepository.SaveWarehouse(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWarehouseList(Warehouse_Search parameters)
        {
            IEnumerable<Warehouse_Response> lstRoles = await _adminMasterRepository.GetWarehouseList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWarehouseById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetWarehouseById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Supplier Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveSupplierType(SupplierType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveSupplierType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetSupplierTypeList(SupplierType_Search parameters)
        {
            IEnumerable<SupplierType_Response> lstRoles = await _adminMasterRepository.GetSupplierTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetSupplierTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetSupplierTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Die Category

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveDieCategory(DieCategory_Request parameters)
        {
            int result = await _adminMasterRepository.SaveDieCategory(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetDieCategoryList(DieCategory_Search parameters)
        {
            IEnumerable<DieCategory_Response> lstRoles = await _adminMasterRepository.GetDieCategoryList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetDieCategoryById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetDieCategoryById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Model

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveModel(Model_Request parameters)
        {
            int result = await _adminMasterRepository.SaveModel(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetModelList(Model_Search parameters)
        {
            IEnumerable<Model_Response> lstRoles = await _adminMasterRepository.GetModelList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetModelById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetModelById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Wheel Diameter

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveWheelDiameter(WheelDiameter_Request parameters)
        {
            int result = await _adminMasterRepository.SaveWheelDiameter(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWheelDiameterList(WheelDiameter_Search parameters)
        {
            IEnumerable<WheelDiameter_Response> lstRoles = await _adminMasterRepository.GetWheelDiameterList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWheelDiameterById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetWheelDiameterById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Wheel Width

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveWheelWidth(WheelWidth_Request parameters)
        {
            int result = await _adminMasterRepository.SaveWheelWidth(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWheelWidthList(WheelWidth_Search parameters)
        {
            IEnumerable<WheelWidth_Response> lstRoles = await _adminMasterRepository.GetWheelWidthList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWheelWidthById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetWheelWidthById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region PCD_N_H

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SavePCD_N_H(PCD_N_H_Request parameters)
        {
            int result = await _adminMasterRepository.SavePCD_N_H(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPCD_N_HList(PCD_N_H_Search parameters)
        {
            IEnumerable<PCD_N_H_Response> lstRoles = await _adminMasterRepository.GetPCD_N_HList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPCD_N_HById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetPCD_N_HById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Inset

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveInset(Inset_Request parameters)
        {
            int result = await _adminMasterRepository.SaveInset(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetInsetList(Inset_Search parameters)
        {
            IEnumerable<Inset_Response> lstRoles = await _adminMasterRepository.GetInsetList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetInsetById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetInsetById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Weight

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveWeight(Weight_Request parameters)
        {
            int result = await _adminMasterRepository.SaveWeight(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWeightList(Weight_Search parameters)
        {
            IEnumerable<Weight_Response> lstRoles = await _adminMasterRepository.GetWeightList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetWeightById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetWeightById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Tyre Size

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveTyreSize(TyreSize_Request parameters)
        {
            int result = await _adminMasterRepository.SaveTyreSize(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetTyreSizeList(TyreSize_Search parameters)
        {
            IEnumerable<TyreSize_Response> lstRoles = await _adminMasterRepository.GetTyreSizeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetTyreSizeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetTyreSizeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Bolt Hole Type

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveBoltHoleType(BoltHoleType_Request parameters)
        {
            int result = await _adminMasterRepository.SaveBoltHoleType(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetBoltHoleTypeList(BoltHoleType_Search parameters)
        {
            IEnumerable<BoltHoleType_Response> lstRoles = await _adminMasterRepository.GetBoltHoleTypeList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetBoltHoleTypeById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetBoltHoleTypeById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Paint

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SavePaint(Paint_Request parameters)
        {
            int result = await _adminMasterRepository.SavePaint(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPaintList(Paint_Search parameters)
        {
            IEnumerable<Paint_Response> lstRoles = await _adminMasterRepository.GetPaintList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetPaintById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetPaintById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion

        #region Material Group

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveMaterialGroup(MaterialGroup_Request parameters)
        {
            int result = await _adminMasterRepository.SaveMaterialGroup(parameters);

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
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMaterialGroupList(MaterialGroup_Search parameters)
        {
            IEnumerable<MaterialGroup_Response> lstRoles = await _adminMasterRepository.GetMaterialGroupList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetMaterialGroupById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _adminMasterRepository.GetMaterialGroupById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        #endregion
    }
}
