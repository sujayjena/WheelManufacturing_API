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
    public class ManagePurchaseRequisitionRepository : GenericRepository, IManagePurchaseRequisitionRepository
    {
        private IConfiguration _configuration;

        public ManagePurchaseRequisitionRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        #region Purchase Requisition
        public async Task<int> SavePurchaseRequisition(PurchaseRequisition_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@PurchaseRequisitionNo", parameters.PurchaseRequisitionNo);
            queryParameters.Add("@PurchaseRequisitionDate", parameters.PurchaseRequisitionDate);
            queryParameters.Add("@RequestedBy", parameters.RequestedBy);
            queryParameters.Add("@ReceivedBy", parameters.ReceivedBy);
            queryParameters.Add("@DepartmentId", parameters.DepartmentId);
            queryParameters.Add("@StatusId", parameters.StatusId);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SavePurchaseRequisition", queryParameters);
        }

        public async Task<IEnumerable<PurchaseRequisitionList_Response>> GetPurchaseRequisitionList(PurchaseRequisition_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<PurchaseRequisitionList_Response>("GetPurchaseRequisitionList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<PurchaseRequisition_Response?> GetPurchaseRequisitionById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<PurchaseRequisition_Response>("GetPurchaseRequisitionById", queryParameters)).FirstOrDefault();
        }
        #endregion

        #region Purchase Requisition Details
        public async Task<int> SavePurchaseRequisitionDetails(PurchaseRequisitionDetails_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@PurchaseRequisitionId", parameters.PurchaseRequisitionId);
            queryParameters.Add("@MaterialMasterId", parameters.MaterialMasterId);
            queryParameters.Add("@Specification", parameters.Specification);
            queryParameters.Add("@RequiredQty", parameters.RequiredQty);
            queryParameters.Add("@RequestedDate", parameters.RequestedDate);
            queryParameters.Add("@OrderRemarks", parameters.OrderRemarks);
            queryParameters.Add("@PriorityId", parameters.PriorityId);
            queryParameters.Add("@SupplierId", parameters.SupplierId);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SavePurchaseRequisitionDetails", queryParameters);
        }

        public async Task<IEnumerable<PurchaseRequisitionDetails_Response>> GetPurchaseRequisitionDetailsList(PurchaseRequisitionDetails_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@PurchaseRequisitionId", parameters.PurchaseRequisitionId);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<PurchaseRequisitionDetails_Response>("GetPurchaseRequisitionDetailsList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        #endregion
    }
}
