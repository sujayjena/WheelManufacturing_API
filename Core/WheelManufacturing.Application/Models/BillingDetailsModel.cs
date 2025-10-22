using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;

namespace WheelManufacturing.Application.Models
{
    public class BillingDetails_Request : BaseEntity
    {
        public int? RefId { get; set; }

        [DefaultValue("Customer")]
        public string? RefType { get; set; }
        public int? IsNational_Or_International { get; set; }
        public string? AddressLine1 { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PinCode { get; set; }

        [DefaultValue(false)]
        public bool? IsGST { get; set; }
        public string? GSTNumber { get; set; }

        [DefaultValue("")]
        public string? GSTOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? GSTFileName { get; set; }

        [DefaultValue("")]
        public string? GST_Base64 { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BillingDetails_Response : BaseEntity
    {
        public int? RefId { get; set; }
        public string? RefType { get; set; }
        public int? IsNational_Or_International { get; set; }
        public string? AddressLine1 { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public int? CityId { get; set; }
        public string? CityName { get; set; }
        public string? PinCode { get; set; }
        public bool? IsGST { get; set; }
        public string? GSTNumber { get; set; }
        public string? GSTOriginalFileName { get; set; }
        public string? GSTFileName { get; set; }
        public string? GSTUrl { get; set; }
        public bool? IsActive { get; set; }
    }
}
