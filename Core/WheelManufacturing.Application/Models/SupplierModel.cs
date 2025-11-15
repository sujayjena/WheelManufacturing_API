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
    public class Supplier_Request : BaseEntity
    {
        public Supplier_Request()
        {
            ContactDetailsList = new List<ContactDetails_Request>();
            BillingDetailsList = new List<BillingDetails_Request>();
            ShippingDetailsList = new List<ShippingDetails_Request>();
        }

        public string? SupplierName { get; set; }
        public string? MobileNo1 { get; set; }
        public string? MobileNo2 { get; set; }
        public int? SupplierTypeId { get; set; }
        public string? EmailId { get; set; }
        public string? ContactName { get; set; }

        [DefaultValue(false)]
        public bool? IsPan { get; set; }
        public string? PanNumber { get; set; }

        [DefaultValue("")]
        public string? PanOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? PanFileName { get; set; }

        [DefaultValue("")]
        public string? Pan_Base64 { get; set; }
        public bool? IsActive { get; set; }

        public List<ContactDetails_Request>? ContactDetailsList { get; set; }
        public List<BillingDetails_Request>? BillingDetailsList { get; set; }
        public List<ShippingDetails_Request>? ShippingDetailsList { get; set; }
    }
    public class SupplierSearch_Request : BaseSearchEntity
    {
    }

    public class Supplier_Response : BaseResponseEntity
    {
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public string? MobileNo1 { get; set; }
        public string? MobileNo2 { get; set; }
        public int? SupplierTypeId { get; set; }
        public string? SupplierType { get; set; }
        public string? EmailId { get; set; }
        public string? ContactName { get; set; }
        public bool? IsPan { get; set; }
        public string? PanNumber { get; set; }
        public string? PanOriginalFileName { get; set; }
        public string? PanFileName { get; set; }
        public string? PanUrl { get; set; }
        public bool? IsActive { get; set; }
    }
}
