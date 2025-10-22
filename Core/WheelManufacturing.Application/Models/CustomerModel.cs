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
    public class Customer_Request : BaseEntity
    {
        public Customer_Request()
        {
            ContactDetailsList = new List<ContactDetails_Request>();
            BillingDetailsList = new List<BillingDetails_Request>();
            ShippingDetailsList = new List<ShippingDetails_Request>();
        }

        public string? CustomerName { get; set; }
        public string? MobileNo1 { get; set; }
        public string? MobileNo2 { get; set; }
        public int? ParentCustomerId { get; set; }
        public int? CustomerTypeId { get; set; }
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

        [JsonIgnore]
        public string? AutoPassword { get; set; }

        public List<ContactDetails_Request>? ContactDetailsList { get; set; }
        public List<BillingDetails_Request>? BillingDetailsList { get; set; }
        public List<ShippingDetails_Request>? ShippingDetailsList { get; set; }
    }

    public class Customer_Response : BaseResponseEntity
    {
        public string? CustomerName { get; set; }
        public string? MobileNo1 { get; set; }
        public string? MobileNo2 { get; set; }
        public int? ParentCustomerId { get; set; }
        public string? ParentCustomer { get; set; }
        public int? CustomerTypeId { get; set; }
        public string? CustomerType { get; set; }
        public string? EmailId { get; set; }
        public string? Passwords { get; set; }
        public string? ContactName { get; set; }
        public bool? IsPan { get; set; }
        public string? PanNumber { get; set; }
        public string? PanOriginalFileName { get; set; }
        public string? PanFileName { get; set; }
        public string? PanUrl { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CustomerSearch_Request : BaseSearchEntity
    {
        [DefaultValue(0)]
        public int CustomerId { get; set; }

        [DefaultValue(0)]
        public int ParentCustomerId { get; set; }
    }

    public class Search_Request : BaseSearchEntity
    {
        [DefaultValue(0)]
        public int RefId { get; set; }

        [DefaultValue("Customer")]
        public string? RefType { get; set; }
    }

    public class AutoGenPassword_Response
    {
        public string? AutoPassword { get; set; }
    }
}
