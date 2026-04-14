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
    public class ManageSupplierPORepository : GenericRepository, IManageSupplierPORepository
    {
        private IConfiguration _configuration;

        public ManageSupplierPORepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        #region SupplierPO
        public async Task<int> SaveSupplierPO(SupplierPO_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@SupplierId", parameters.SupplierId);
            queryParameters.Add("@PONumber", parameters.PONumber);
            queryParameters.Add("@PODate", parameters.PODate);
            queryParameters.Add("@PaymentTermId", parameters.PaymentTermId);
            queryParameters.Add("@PurchaseOrderType", parameters.PurchaseOrderType);
            queryParameters.Add("@BillingAddressId", parameters.BillingAddressId);
            queryParameters.Add("@ShippingAddressId", parameters.ShippingAddressId);
            queryParameters.Add("@SubTotal", parameters.SubTotal);
            queryParameters.Add("@TotalCGST", parameters.TotalCGST);
            queryParameters.Add("@TotalSGST", parameters.TotalSGST);
            queryParameters.Add("@TotalIGST", parameters.TotalIGST);
            queryParameters.Add("@TotalValue", parameters.TotalValue);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveSupplierPO", queryParameters);
        }

        public async Task<IEnumerable<SupplierPOList_Response>> GetSupplierPOList(SupplierPO_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<SupplierPOList_Response>("GetSupplierPOList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<SupplierPO_Response?> GetSupplierPOById(int Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", Id);

            return (await ListByStoredProcedure<SupplierPO_Response>("GetSupplierPOById", queryParameters)).FirstOrDefault();
        }

        #endregion

        #region SupplierPO Details
        public async Task<int> SaveSupplierPODetails(SupplierPODetails_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@SupplierPOId", parameters.SupplierPOId);
            queryParameters.Add("@PurchaseRequisitionId", parameters.PurchaseRequisitionId);
            queryParameters.Add("@MaterialMasterId", parameters.MaterialMasterId);
            queryParameters.Add("@Discount", parameters.Discount);
            queryParameters.Add("@Rate", parameters.Rate);
            queryParameters.Add("@Amount", parameters.Amount);
            queryParameters.Add("@TaxableValue", parameters.TaxableValue);
            queryParameters.Add("@FreightCharge", parameters.FreightCharge);
            queryParameters.Add("@GSTPerctType", parameters.GSTPerctType);
            queryParameters.Add("@Labour", parameters.Labour);
            queryParameters.Add("@Loading", parameters.Loading);
            queryParameters.Add("@UnLoading", parameters.UnLoading);
            queryParameters.Add("@IsCGST", parameters.IsCGST);
            queryParameters.Add("@CGSTPerct", parameters.CGSTPerct);
            queryParameters.Add("@CGSTAmt", parameters.CGSTAmt);
            queryParameters.Add("@IsSGST", parameters.IsSGST);
            queryParameters.Add("@SGSTPerct", parameters.SGSTPerct);
            queryParameters.Add("@SGSTAmt", parameters.SGSTAmt);
            queryParameters.Add("@IsIGST", parameters.IsIGST);
            queryParameters.Add("@IGSTPerct", parameters.IGSTPerct);
            queryParameters.Add("@IGSTAmt", parameters.IGSTAmt);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveSupplierPODetails", queryParameters);
        }
        public async Task<IEnumerable<SupplierPODetails_Response>> GetSupplierPODetailsList(SupplierPODetails_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@SupplierPOId", parameters.SupplierPOId);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<SupplierPODetails_Response>("GetSupplierPODetailsList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }
        public async Task<int> DeleteSupplierPODetails(int Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();

            queryParameters.Add("@Id", Id);

            return await SaveByStoredProcedure<int>("DeleteSupplierPODetails", queryParameters);
        }
        #endregion
    }
}
