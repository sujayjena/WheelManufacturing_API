using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;
using WheelManufacturing.Persistence.Repositories;

namespace WheelManufacturing.Application.Models
{
    public class Branch_Request : BaseEntity
    {
        public string? BranchName { get; set; }
        public int? CompanyId { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? DepartmentHead { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
        public int? Pincode { get; set; }
        public int? NoofUserAdd { get; set; }

        [DefaultValue(false)]
        public bool? IsBarcode { get; set; }
        public DateTime? BarcodeStartDate { get; set; }
        public DateTime? BarcodeEndDate { get; set; }
        public decimal? BarcodePerPrice { get; set; }
        public int? CountOfBarcode { get; set; }

        [DefaultValue(false)]
        public bool? IsQRcode { get; set; }
        public DateTime? QRcodeStartDate { get; set; }
        public DateTime? QRcodeEndDate { get; set; }
        public decimal? QRcodePerPrice { get; set; }
        public int? CountOfQRcode { get; set; }
        public bool? IsActive { get; set; }
    }
    public class BranchSearch_Request : BaseSearchEntity
    {
        public int? CompanyId { get; set; }
    }
    public class Branch_Response : BaseResponseEntity
    {
        public string? BranchName { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? DepartmentHead { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public int? Pincode { get; set; }
        public int? NoofUserAdd { get; set; }
        public bool? IsBarcode { get; set; }
        public DateTime? BarcodeStartDate { get; set; }
        public DateTime? BarcodeEndDate { get; set; }
        public decimal? BarcodePerPrice { get; set; }
        public int? CountOfBarcode { get; set; }
        public bool? IsQRcode { get; set; }
        public DateTime? QRcodeStartDate { get; set; }
        public DateTime? QRcodeEndDate { get; set; }
        public decimal? QRcodePerPrice { get; set; }
        public int? CountOfQRcode { get; set; }
        public bool? IsActive { get; set; }
    }
}
