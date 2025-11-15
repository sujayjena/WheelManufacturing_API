using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;

namespace WheelManufacturing.Application.Models
{
    public class ContactDetails_Request : BaseEntity
    {
        public int? RefId { get; set; }

        [DefaultValue("Customer")]
        public string? RefType { get; set; }
        public string? ContactPerson { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public bool? IsActive { get; set; }
    }
    public class ContactDetails_Response : BaseEntity
    {
        public int? RefId { get; set; }
        public string? RefType { get; set; }
        //public string? CustomerName { get; set; }
        public string? ContactPerson { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public bool? IsActive { get; set; }
    }
}
