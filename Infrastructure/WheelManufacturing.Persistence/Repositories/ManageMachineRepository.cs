using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Helpers;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Persistence.Repositories
{
    public class ManageMachineRepository : GenericRepository, IManageMachineRepository
    {
        private IConfiguration _configuration;

        public ManageMachineRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        #region Machine Assign
        public async Task<int> SaveMachineAssign(MachineAssign_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@MachineId", parameters.MachineId);
            queryParameters.Add("@ShiftType", parameters.ShiftType);
            queryParameters.Add("@EmployeeId", parameters.EmployeeId);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveMachineAssign", queryParameters);
        }

        public async Task<IEnumerable<MachineAssign_Response>> GetMachineAssignList(MachineAssign_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@FromDate", parameters.FromDate);
            queryParameters.Add("@ToDate", parameters.ToDate);
            queryParameters.Add("@ShiftType", parameters.ShiftType);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<MachineAssign_Response>("GetMachineAssignList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }
        public async Task<IEnumerable<MachineListForAssignOperator_Response>> GetMachineListForAssignOperator(MachineListForAssignOperator_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@ShiftType", parameters.ShiftType);
            queryParameters.Add("@IsAssign", parameters.IsAssign);
            queryParameters.Add("@EmployeeId", parameters.EmployeeId);
            queryParameters.Add("@IsIdle", parameters.IsIdle);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<MachineListForAssignOperator_Response>("GetMachineListForAssignOperator", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }
        public async Task<IEnumerable<OperatorNameSelectList_Response>> GetOperatorNameForSelectList(OperatorNameSelectList_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@ShiftType", parameters.ShiftType);
            queryParameters.Add("@IsPresent", parameters.IsPresent);

            return await ListByStoredProcedure<OperatorNameSelectList_Response>("GetOperatorNameForSelectList", queryParameters);
        }
        #endregion
    }
}
