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
    }
}
