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
    #region Machine Assign
    public class MachineAssign_Request : BaseEntity
    {
        public int? MachineId { get; set; }
        public int? ShiftType { get; set; }
        public int? EmployeeId { get; set; }
    }
    public class MachineAssign_Search : BaseSearchEntity
    {
        [DefaultValue(null)]
        public DateTime? FromDate { get; set; }

        [DefaultValue(null)]
        public DateTime? ToDate { get; set; }
        public int ShiftType { get; set; }
    }

    public class MachineAssign_Response : BaseResponseEntity
    {
        public int? MachineId { get; set; }
        public string? MachineName { get; set; }
        public int? ShiftType { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
    }

    public class MachineListForAssignOperator_Search : BaseSearchEntity
    {
        public int? ShiftType { get; set; }
        public bool? IsAssign { get; set; }
        public int? EmployeeId { get; set; }

        [DefaultValue(false)]
        public bool? IsIdle { get; set; }
    }

    public class MachineListForAssignOperator_Response
    {
        public int? Id { get; set; }
        public string? MachineName { get; set; }
    }
    public class OperatorNameSelectList_Search
    {
        public int? ShiftType { get; set; }

        [DefaultValue(null)]
        public bool? IsPresent { get; set; }
    }
    public class OperatorNameSelectList_Response
    {
        public long Value { get; set; }
        public string? Text { get; set; }
        public string? MachineName { get; set; }
        public bool? IsPresent { get; set; }
    }

    #endregion
}
