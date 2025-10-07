using WheelManufacturing.Domain.Entities;
using WheelManufacturing.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WheelManufacturing.Application.Models
{
    #region Blood Group
    public class BloodGroup_Search : BaseSearchEntity
    {
    }

    public class BloodGroup_Request : BaseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BloodGroup_Response : BaseResponseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Company Type

    public class CompanyType_Search : BaseSearchEntity
    {
    }

    public class CompanyType_Request : BaseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CompanyType_Response : BaseResponseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Customer Type

    public class CustomerType_Search : BaseSearchEntity
    {
    }

    public class CustomerType_Request : BaseEntity
    {
        public string? CustomerType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CustomerType_Response : BaseResponseEntity
    {
        public string? CustomerType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Leave Type

    public class LeaveType_Search : BaseSearchEntity
    {
    }

    public class LeaveType_Request : BaseEntity
    {
        public string? LeaveType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class LeaveType_Response : BaseResponseEntity
    {
        public string? LeaveType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Gender
    public class Gender_Search : BaseSearchEntity
    {
    }

    public class Gender_Request : BaseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Gender_Response : BaseResponseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Marital Status
    public class MaritalStatus_Search : BaseSearchEntity
    {
    }

    public class MaritalStatus_Request : BaseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaritalStatus_Response : BaseResponseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Expense Type

    public class ExpenseType_Search : BaseSearchEntity
    {
    }

    public class ExpenseType_Request : BaseEntity
    {
        public string? ExpenseType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ExpenseType_Response : BaseResponseEntity
    {
        public string? ExpenseType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Activity Type

    public class ActivityType_Search : BaseSearchEntity
    {
    }

    public class ActivityType_Request : BaseEntity
    {
        public string? ActivityType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ActivityType_Response : BaseResponseEntity
    {
        public string? ActivityType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Activity Status

    public class ActivityStatus_Search : BaseSearchEntity
    {
    }

    public class ActivityStatus_Request : BaseEntity
    {
        public string? ActivityStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ActivityStatus_Response : BaseResponseEntity
    {
        public string? ActivityStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Renewal Type

    public class RenewalType_Search : BaseSearchEntity
    {
    }

    public class RenewalType_Request : BaseEntity
    {
        public string? RenewalType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class RenewalType_Response : BaseResponseEntity
    {
        public string? RenewalType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Supplier Type

    public class SupplierType_Search : BaseSearchEntity
    {
    }

    public class SupplierType_Request : BaseEntity
    {
        public string? SupplierType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class SupplierType_Response : BaseResponseEntity
    {
        public string? SupplierType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion
}
