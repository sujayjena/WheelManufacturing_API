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

    #region Priority

    public class Priority_Search : BaseSearchEntity
    {
    }

    public class Priority_Request : BaseEntity
    {
        public string? PriorityName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Priority_Response : BaseResponseEntity
    {
        public string? PriorityName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Version Details

    public class VersionDetails_Search : BaseSearchEntity
    {
        public string? PackageName { get; set; }
        public string? UpdateType { get; set; }
    }

    public class VersionDetails_Request : BaseEntity
    {
        public int? AppVersionNo { get; set; }
        public string? AppVersionName { get; set; }
        public string? UpdateMsg { get; set; }
        public string? PackageName { get; set; }
        public string? UpdateType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class VersionDetails_Response : BaseResponseEntity
    {
        public int? AppVersionNo { get; set; }
        public string? AppVersionName { get; set; }
        public string? UpdateMsg { get; set; }
        public string? PackageName { get; set; }
        public string? UpdateType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region UOM

    public class UOM_Search : BaseSearchEntity
    {
    }

    public class UOM_Request : BaseEntity
    {
        public string? UOMName { get; set; }
        public string? UOMDesc { get; set; }
        public bool? IsActive { get; set; }
    }

    public class UOM_Response : BaseResponseEntity
    {
        public string? UOMName { get; set; }
        public string? UOMDesc { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Warehouse

    public class Warehouse_Search : BaseSearchEntity
    {
    }

    public class Warehouse_Request : BaseEntity
    {
        public string? WarehouseName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Warehouse_Response : BaseResponseEntity
    {
        public string? WarehouseName { get; set; }
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
