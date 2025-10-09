using WheelManufacturing.Application.Models;
using WheelManufacturing.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IAdminMasterRepository
    {
        #region Blood Group

        Task<int> SaveBloodGroup(BloodGroup_Request parameters);
        Task<IEnumerable<BloodGroup_Response>> GetBloodGroupList(BloodGroup_Search parameters);
        Task<BloodGroup_Response?> GetBloodGroupById(long Id);

        #endregion

        #region Company Type

        Task<int> SaveCompanyType(CompanyType_Request parameters);
        Task<IEnumerable<CompanyType_Response>> GetCompanyTypeList(CompanyType_Search parameters);
        Task<CompanyType_Response?> GetCompanyTypeById(long Id);

        #endregion

        #region Customer Type

        Task<int> SaveCustomerType(CustomerType_Request parameters);
        Task<IEnumerable<CustomerType_Response>> GetCustomerTypeList(CustomerType_Search parameters);
        Task<CustomerType_Response?> GetCustomerTypeById(long Id);

        #endregion

        #region Leave Type

        Task<int> SaveLeaveType(LeaveType_Request parameters);
        Task<IEnumerable<LeaveType_Response>> GetLeaveTypeList(LeaveType_Search parameters);
        Task<LeaveType_Response?> GetLeaveTypeById(long Id);

        #endregion

        #region Gender

        Task<int> SaveGender(Gender_Request parameters);
        Task<IEnumerable<Gender_Response>> GetGenderList(Gender_Search parameters);
        Task<Gender_Response?> GetGenderById(long Id);

        #endregion

        #region Marital Status

        Task<int> SaveMaritalStatus(MaritalStatus_Request parameters);
        Task<IEnumerable<MaritalStatus_Response>> GetMaritalStatusList(MaritalStatus_Search parameters);
        Task<MaritalStatus_Response?> GetMaritalStatusById(long Id);

        #endregion

        #region Expense Type

        Task<int> SaveExpenseType(ExpenseType_Request parameters);
        Task<IEnumerable<ExpenseType_Response>> GetExpenseTypeList(ExpenseType_Search parameters);
        Task<ExpenseType_Response?> GetExpenseTypeById(long Id);

        #endregion

        #region Activity Type

        Task<int> SaveActivityType(ActivityType_Request parameters);
        Task<IEnumerable<ActivityType_Response>> GetActivityTypeList(ActivityType_Search parameters);
        Task<ActivityType_Response?> GetActivityTypeById(long Id);

        #endregion

        #region Activity Status

        Task<int> SaveActivityStatus(ActivityStatus_Request parameters);
        Task<IEnumerable<ActivityStatus_Response>> GetActivityStatusList(ActivityStatus_Search parameters);
        Task<ActivityStatus_Response?> GetActivityStatusById(long Id);

        #endregion

        #region Renewal Type

        Task<int> SaveRenewalType(RenewalType_Request parameters);
        Task<IEnumerable<RenewalType_Response>> GetRenewalTypeList(RenewalType_Search parameters);
        Task<RenewalType_Response?> GetRenewalTypeById(long Id);

        #endregion

        #region Priority

        Task<int> SavePriority(Priority_Request parameters);
        Task<IEnumerable<Priority_Response>> GetPriorityList(Priority_Search parameters);
        Task<Priority_Response?> GetPriorityById(long Id);

        #endregion

        #region Version Details

        Task<int> SaveVersionDetails(VersionDetails_Request parameters);
        Task<IEnumerable<VersionDetails_Response>> GetVersionDetailsList(VersionDetails_Search parameters);
        Task<VersionDetails_Response?> GetVersionDetailsById(long Id);

        #endregion

        #region UOM

        Task<int> SaveUOM(UOM_Request parameters);
        Task<IEnumerable<UOM_Response>> GetUOMList(UOM_Search parameters);
        Task<UOM_Response?> GetUOMById(long Id);

        #endregion

        #region Warehouse

        Task<int> SaveWarehouse(Warehouse_Request parameters);
        Task<IEnumerable<Warehouse_Response>> GetWarehouseList(Warehouse_Search parameters);
        Task<Warehouse_Response?> GetWarehouseById(long Id);

        #endregion

        #region Supplier Type

        Task<int> SaveSupplierType(SupplierType_Request parameters);
        Task<IEnumerable<SupplierType_Response>> GetSupplierTypeList(SupplierType_Search parameters);
        Task<SupplierType_Response?> GetSupplierTypeById(long Id);

        #endregion
    }
}
