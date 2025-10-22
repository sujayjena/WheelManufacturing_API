using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;

namespace WheelManufacturing.Application.Models
{
    public class ShippingDetails_Request : BaseEntity
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
        public bool? IsActive { get; set; }
    }

    public class ShippingDetails_Response : BaseEntity
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
        public bool? IsActive { get; set; }
    }
}
