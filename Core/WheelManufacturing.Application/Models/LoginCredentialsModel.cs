using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;

namespace WheelManufacturing.Application.Models
{
    public class LoginCredentials_Request : BaseEntity
    {
        public int? RefId { get; set; }

        [DefaultValue("Customer")]
        public string? RefType { get; set; }
        public string? ContactName { get; set; }
        public string? MobileNo { get; set; }
        public string? Passwords { get; set; }
        public bool? IsActive { get; set; }
    }
    public class LoginCredentials_Response : BaseEntity
    {
        public int? RefId { get; set; }
        public string? RefType { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactName { get; set; }
        public string? MobileNo { get; set; }
        public string? Passwords { get; set; }
        public bool? IsActive { get; set; }
    }
}
