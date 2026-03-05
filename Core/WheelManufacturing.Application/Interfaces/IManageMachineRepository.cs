using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IManageMachineRepository
    {
        #region Machine Assign
        Task<int> SaveMachineAssign(MachineAssign_Request parameters);
        Task<IEnumerable<MachineAssign_Response>> GetMachineAssignList(MachineAssign_Search parameters);
        Task<IEnumerable<MachineListForAssignOperator_Response>> GetMachineListForAssignOperator(MachineListForAssignOperator_Search parameters);
        Task<IEnumerable<OperatorNameSelectList_Response>> GetOperatorNameForSelectList(OperatorNameSelectList_Search parameters);
        #endregion
    }
}
