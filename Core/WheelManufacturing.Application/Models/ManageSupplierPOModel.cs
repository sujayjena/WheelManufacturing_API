using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;
using WheelManufacturing.Persistence.Repositories;

namespace WheelManufacturing.Application.Models
{
    #region Supplier PO
    public class SupplierPO_Search : BaseSearchEntity
    {
    }

    public class SupplierPO_Request : BaseEntity
    {
        public SupplierPO_Request()
        {
            supplierPODetailsList = new List<SupplierPODetails_Request>();
        }
        public int? SupplierId { get; set; }
        public string? PONumber { get; set; }
        public DateTime? PODate { get; set; }

        [JsonIgnore]
        public string? POAmendNo { get; set; }

        [JsonIgnore]
        public DateTime? POAmendDate { get; set; }
        public int? PaymentTermId { get; set; }

        [DefaultValue(1)]
        public int? PurchaseOrderType { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalCGST { get; set; }
        public decimal? TotalSGST { get; set; }
        public decimal? TotalIGST { get; set; }
        public decimal? TotalValue { get; set; }
        public bool? IsActive { get; set; }

        public List<SupplierPODetails_Request> supplierPODetailsList { get; set; }
    }

    public class SupplierPOList_Response : BaseResponseEntity
    {
        public string? PONumber { get; set; }
        public DateTime? PODate { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public string? ContactPerson { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? PanNumber { get; set; }
        public string? GSTNumber { get; set; }
        public string? AddressLine1 { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public string? PinCode { get; set; }
        public int? PurchaseOrderType { get; set; }
        public string? POAmendNo { get; set; }
        public DateTime? POAmendDate { get; set; }
        public int? PaymentTermId { get; set; }
        public string? PaymentTermName { get; set; }
        public decimal? TotalValue { get; set; }
        public bool? IsActive { get; set; }
    }

    public class SupplierPO_Response : BaseResponseEntity
    {
        public SupplierPO_Response()
        {
            supplierPODetailsList = new List<SupplierPODetails_Response>();
        }
        public int? SupplierId { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public string? ContactPerson { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? PanNumber { get; set; }
        public string? GSTNumber { get; set; }
        public string? AddressLine1 { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public string? PinCode { get; set; }
        public string? PONumber { get; set; }
        public DateTime? PODate { get; set; }
        public string? POAmendNo { get; set; }
        public DateTime? POAmendDate { get; set; }
        public int? PaymentTermId { get; set; }
        public string? PaymentTermName { get; set; }
        public int? PurchaseOrderType { get; set; }
        public int? BillingAddressId { get; set; }
        public int? BillingIsNational_Or_International { get; set; }
        public string? BillingAddress { get; set; }
        public int? BillingCountryId { get; set; }
        public string? BillingCountryName { get; set; }
        public int? BillingStateId { get; set; }
        public string? BillingStateName { get; set; }
        public int? BillingDistrictId { get; set; }
        public string? BillingDistrictName { get; set; }
        public string? BillingPinCode { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? ShippingIsNational_Or_International { get; set; }
        public string? ShippingAddress { get; set; }
        public int? ShippingCountryId { get; set; }
        public string? ShippingCountryName { get; set; }
        public int? ShippingStateId { get; set; }
        public string? ShippingStateName { get; set; }
        public int? ShippingDistrictId { get; set; }
        public string? ShippingDistrictName { get; set; }
        public string? ShippingPinCode { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalCGST { get; set; }
        public decimal? TotalSGST { get; set; }
        public decimal? TotalIGST { get; set; }
        public decimal? TotalValue { get; set; }
        public bool? IsActive { get; set; }
        public List<SupplierPODetails_Response> supplierPODetailsList { get; set; }
    }
    #endregion

    #region SupplierPO Details
    public class SupplierPODetails_Search : BaseSearchEntity
    {
        public int? SupplierPOId { get; set; }
    }
    public class SupplierPODetails_Request : BaseEntity
    {
        public int? SupplierPOId { get; set; }
        public int? PurchaseRequisitionId { get; set; }
        public int? MaterialMasterId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
       
        public decimal? TaxableValue { get; set; }
        public decimal? FreightCharge { get; set; }
        public int? GSTPerctType { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Loading { get; set; }
        public decimal? UnLoading { get; set; }

        [DefaultValue(false)]
        public bool? IsCGST { get; set; }
        public decimal? CGSTPerct { get; set; }
        public decimal? CGSTAmt { get; set; }

        [DefaultValue(false)]
        public bool? IsSGST { get; set; }
        public decimal? SGSTPerct { get; set; }
        public decimal? SGSTAmt { get; set; }

        [DefaultValue(false)]
        public bool? IsIGST { get; set; }
        public decimal? IGSTPerct { get; set; }
        public decimal? IGSTAmt { get; set; }
        public bool? IsActive { get; set; }
    }

    public class SupplierPODetails_Response : BaseResponseEntity
    {
        public int? SupplierPOId { get; set; }
        public string? PONumber { get; set; }
        public int? PurchaseRequisitionId { get; set; }
        public string? PurchaseRequisitionNo { get; set; }
        public int? MaterialMasterId { get; set; }
        public string? ItemCode { get; set; }
        public int? MaterialGroupId { get; set; }
        public string? MaterialGroup { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public string? Specification { get; set; }
        public decimal? RequiredQty { get; set; }
        public string? OrderRemarks { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TaxableValue { get; set; }
        public decimal? FreightCharge { get; set; }
        public int? GSTPerctType { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Loading { get; set; }
        public decimal? UnLoading { get; set; }

        public bool? IsCGST { get; set; }
        public decimal? CGSTPerct { get; set; }
        public decimal? CGSTAmt { get; set; }

        public bool? IsSGST { get; set; }
        public decimal? SGSTPerct { get; set; }
        public decimal? SGSTAmt { get; set; }

        public bool? IsIGST { get; set; }
        public decimal? IGSTPerct { get; set; }
        public decimal? IGSTAmt { get; set; }

        public bool? IsActive { get; set; }
    }
    #endregion
}
