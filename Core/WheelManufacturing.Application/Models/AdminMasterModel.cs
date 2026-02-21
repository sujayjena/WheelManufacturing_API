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

    #region Die Category

    public class DieCategory_Search : BaseSearchEntity
    {
    }

    public class DieCategory_Request : BaseEntity
    {
        public string? DieCategory { get; set; }
        public bool? IsActive { get; set; }
    }

    public class DieCategory_Response : BaseResponseEntity
    {
        public string? DieCategory { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Model

    public class Model_Search : BaseSearchEntity
    {
    }

    public class Model_Request : BaseEntity
    {
        public string? ModelName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Model_Response : BaseResponseEntity
    {
        public string? ModelName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Wheel Diameter

    public class WheelDiameter_Search : BaseSearchEntity
    {
    }

    public class WheelDiameter_Request : BaseEntity
    {
        public string? WheelDiameter { get; set; }
        public int? UOMId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class WheelDiameter_Response : BaseResponseEntity
    {
        public string? WheelDiameter { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Wheel Width

    public class WheelWidth_Search : BaseSearchEntity
    {
    }

    public class WheelWidth_Request : BaseEntity
    {
        public string? WheelWidth { get; set; }
        public int? UOMId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class WheelWidth_Response : BaseResponseEntity
    {
        public string? WheelWidth { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region PCD_N_H

    public class PCD_N_H_Search : BaseSearchEntity
    {
    }

    public class PCD_N_H_Request : BaseEntity
    {
        public string? PCD_N_H { get; set; }
        public bool? IsActive { get; set; }
    }

    public class PCD_N_H_Response : BaseResponseEntity
    {
        public string? PCD_N_H { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Inset

    public class Inset_Search : BaseSearchEntity
    {
    }

    public class Inset_Request : BaseEntity
    {
        public string? InsetName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Inset_Response : BaseResponseEntity
    {
        public string? InsetName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Weight

    public class Weight_Search : BaseSearchEntity
    {
    }

    public class Weight_Request : BaseEntity
    {
        public string? WeightName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Weight_Response : BaseResponseEntity
    {
        public string? WeightName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Tyre Size

    public class TyreSize_Search : BaseSearchEntity
    {
    }

    public class TyreSize_Request : BaseEntity
    {
        public string? TyreSize { get; set; }
        public bool? IsActive { get; set; }
    }

    public class TyreSize_Response : BaseResponseEntity
    {
        public string? TyreSize { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Bolt Hole Type

    public class BoltHoleType_Search : BaseSearchEntity
    {
    }

    public class BoltHoleType_Request : BaseEntity
    {
        public string? BoltHoleType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BoltHoleType_Response : BaseResponseEntity
    {
        public string? BoltHoleType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Paint

    public class Paint_Search : BaseSearchEntity
    {
    }

    public class Paint_Request : BaseEntity
    {
        public string? PaintName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Paint_Response : BaseResponseEntity
    {
        public string? PaintName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Product Master

    public class ProductMaster_Search : BaseSearchEntity
    {
    }

    public class ProductMaster_Request : BaseEntity
    {
        public int? DieCategoryId { get; set; }
        public int? ModelId { get; set; }
        public int? WheelDiameterId { get; set; }
        public int? WheelWidthId { get; set; }
        public int? PCD_N_HId { get; set; }
        public int? InsetId { get; set; }
        public int? WeightId { get; set; }
        public int? TyreSizeId { get; set; }
        public int? BoltHoleTypeId { get; set; }
        public int? PaintId { get; set; }
        public string? UploadImageOriginalFileName { get; set; }
        public string? UploadImageFileName { get; set; }
        public string? UploadImage_Base64 { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ProductMaster_Response : BaseResponseEntity
    {
        public int? DieCategoryId { get; set; }
        public string? DieCategory { get; set; }
        public int? ModelId { get; set; }
        public string? ModelName { get; set; }
        public int? WheelDiameterId { get; set; }
        public string? WheelDiameter { get; set; }
        public int? WheelWidthId { get; set; }
        public string? WheelWidth { get; set; }
        public int? PCD_N_HId { get; set; }
        public string? PCD_N_H { get; set; }
        public int? InsetId { get; set; }
        public string? InsetName { get; set; }
        public int? WeightId { get; set; }
        public string? WeightName { get; set; }
        public int? TyreSizeId { get; set; }
        public string? TyreSize { get; set; }
        public int? BoltHoleTypeId { get; set; }
        public string? BoltHoleType { get; set; }
        public int? PaintId { get; set; }
        public string? PaintName { get; set; }
        public string? UploadImageOriginalFileName { get; set; }
        public string? UploadImageFileName { get; set; }
        public string? UploadImageURL { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Material Group

    public class MaterialGroup_Search : BaseSearchEntity
    {
    }

    public class MaterialGroup_Request : BaseEntity
    {
        public string? MaterialGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaterialGroup_Response : BaseResponseEntity
    {
        public string? MaterialGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Material Name

    public class MaterialName_Search : BaseSearchEntity
    {
    }

    public class MaterialName_Request : BaseEntity
    {
        public string? MaterialName { get; set; }
        public int? UOMId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaterialName_Response : BaseResponseEntity
    {
        public string? MaterialName { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Material Master

    public class MaterialMaster_Search : BaseSearchEntity
    {
    }

    public class MaterialMaster_Request : BaseEntity
    {
        public int? DepartmentId { get; set; }
        public int? MaterialGroupId { get; set; }
        public int? UOMId { get; set; }
        public int? MaterialNameId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaterialMaster_Response : BaseResponseEntity
    {
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? MaterialGroupId { get; set; }
        public string? MaterialGroup { get; set; }
        public int? MaterialNameId { get; set; }
        public string? MaterialName { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Supply Term

    public class SupplyTerm_Search : BaseSearchEntity
    {
    }

    public class SupplyTerm_Request : BaseEntity
    {
        public string? SupplyTermName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class SupplyTerm_Response : BaseResponseEntity
    {
        public string? SupplyTermName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Payment Mode

    public class PaymentMode_Search : BaseSearchEntity
    {
    }

    public class PaymentMode_Request : BaseEntity
    {
        public string? PaymentMode { get; set; }
        public bool? IsActive { get; set; }
    }

    public class PaymentMode_Response : BaseResponseEntity
    {
        public string? PaymentMode { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Terms Condition

    public class TermsCondition_Search : BaseSearchEntity
    {
    }

    public class TermsCondition_Request : BaseEntity
    {
        public string? TermsConditionName { get; set; }

        [DefaultValue(false)]
        public bool? IsStandard { get; set; }
        public bool? IsActive { get; set; }
    }

    public class TermsCondition_Response : BaseResponseEntity
    {
        public string? TermsConditionName { get; set; }
        public bool? IsStandard { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Shift Type

    public class ShiftType_Search : BaseSearchEntity
    {
    }

    public class ShiftType_Request : BaseEntity
    {
        public string? ShiftType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ShiftType_Response : BaseResponseEntity
    {
        public string? ShiftType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion
}
