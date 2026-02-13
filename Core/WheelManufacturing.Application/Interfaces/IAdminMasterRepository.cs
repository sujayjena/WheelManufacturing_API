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

        #region Die Category

        Task<int> SaveDieCategory(DieCategory_Request parameters);
        Task<IEnumerable<DieCategory_Response>> GetDieCategoryList(DieCategory_Search parameters);
        Task<DieCategory_Response?> GetDieCategoryById(long Id);

        #endregion

        #region Model

        Task<int> SaveModel(Model_Request parameters);
        Task<IEnumerable<Model_Response>> GetModelList(Model_Search parameters);
        Task<Model_Response?> GetModelById(long Id);

        #endregion

        #region Wheel Diameter

        Task<int> SaveWheelDiameter(WheelDiameter_Request parameters);
        Task<IEnumerable<WheelDiameter_Response>> GetWheelDiameterList(WheelDiameter_Search parameters);
        Task<WheelDiameter_Response?> GetWheelDiameterById(long Id);

        #endregion

        #region Wheel Width

        Task<int> SaveWheelWidth(WheelWidth_Request parameters);
        Task<IEnumerable<WheelWidth_Response>> GetWheelWidthList(WheelWidth_Search parameters);
        Task<WheelWidth_Response?> GetWheelWidthById(long Id);

        #endregion

        #region PCD_N_H

        Task<int> SavePCD_N_H(PCD_N_H_Request parameters);
        Task<IEnumerable<PCD_N_H_Response>> GetPCD_N_HList(PCD_N_H_Search parameters);
        Task<PCD_N_H_Response?> GetPCD_N_HById(long Id);

        #endregion

        #region Inset

        Task<int> SaveInset(Inset_Request parameters);
        Task<IEnumerable<Inset_Response>> GetInsetList(Inset_Search parameters);
        Task<Inset_Response?> GetInsetById(long Id);

        #endregion

        #region Weight

        Task<int> SaveWeight(Weight_Request parameters);
        Task<IEnumerable<Weight_Response>> GetWeightList(Weight_Search parameters);
        Task<Weight_Response?> GetWeightById(long Id);

        #endregion

        #region Tyre Size

        Task<int> SaveTyreSize(TyreSize_Request parameters);
        Task<IEnumerable<TyreSize_Response>> GetTyreSizeList(TyreSize_Search parameters);
        Task<TyreSize_Response?> GetTyreSizeById(long Id);

        #endregion

        #region Bolt Hole Type

        Task<int> SaveBoltHoleType(BoltHoleType_Request parameters);
        Task<IEnumerable<BoltHoleType_Response>> GetBoltHoleTypeList(BoltHoleType_Search parameters);
        Task<BoltHoleType_Response?> GetBoltHoleTypeById(long Id);

        #endregion

        #region Paint

        Task<int> SavePaint(Paint_Request parameters);
        Task<IEnumerable<Paint_Response>> GetPaintList(Paint_Search parameters);
        Task<Paint_Response?> GetPaintById(long Id);

        #endregion

        #region Product Master

        Task<int> SaveProductMaster(ProductMaster_Request parameters);
        Task<IEnumerable<ProductMaster_Response>> GetProductMasterList(ProductMaster_Search parameters);
        Task<ProductMaster_Response?> GetProductMasterById(long Id);

        #endregion

        #region Material Group

        Task<int> SaveMaterialGroup(MaterialGroup_Request parameters);
        Task<IEnumerable<MaterialGroup_Response>> GetMaterialGroupList(MaterialGroup_Search parameters);
        Task<MaterialGroup_Response?> GetMaterialGroupById(long Id);

        #endregion

        #region Material Name

        Task<int> SaveMaterialName(MaterialName_Request parameters);
        Task<IEnumerable<MaterialName_Response>> GetMaterialNameList(MaterialName_Search parameters);
        Task<MaterialName_Response?> GetMaterialNameById(long Id);

        #endregion

        #region Material Master

        Task<int> SaveMaterialMaster(MaterialMaster_Request parameters);
        Task<IEnumerable<MaterialMaster_Response>> GetMaterialMasterList(MaterialMaster_Search parameters);
        Task<MaterialMaster_Response?> GetMaterialMasterById(long Id);

        #endregion

        #region Supply Term

        Task<int> SaveSupplyTerm(SupplyTerm_Request parameters);
        Task<IEnumerable<SupplyTerm_Response>> GetSupplyTermList(SupplyTerm_Search parameters);
        Task<SupplyTerm_Response?> GetSupplyTermById(long Id);

        #endregion

        #region Payment Mode

        Task<int> SavePaymentMode(PaymentMode_Request parameters);
        Task<IEnumerable<PaymentMode_Response>> GetPaymentModeList(PaymentMode_Search parameters);
        Task<PaymentMode_Response?> GetPaymentModeById(long Id);

        #endregion

        #region Terms Condition

        Task<int> SaveTermsCondition(TermsCondition_Request parameters);
        Task<IEnumerable<TermsCondition_Response>> GetTermsConditionList(TermsCondition_Search parameters);
        Task<TermsCondition_Response?> GetTermsConditionById(long Id);

        #endregion

        #region Shift Type

        Task<int> SaveShiftType(ShiftType_Request parameters);
        Task<IEnumerable<ShiftType_Response>> GetShiftTypeList(ShiftType_Search parameters);
        Task<ShiftType_Response?> GetShiftTypeById(long Id);

        #endregion
    }
}
