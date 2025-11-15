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
    public class SupplierRepository : GenericRepository, ISupplierRepository
    {
        private IConfiguration _configuration;

        public SupplierRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> SaveSupplier(Supplier_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@SupplierName", parameters.SupplierName);
            queryParameters.Add("@MobileNo1", parameters.MobileNo1);
            queryParameters.Add("@MobileNo2", parameters.MobileNo2);
            queryParameters.Add("@SupplierTypeId", parameters.SupplierTypeId);
            queryParameters.Add("@EmailId", parameters.EmailId);
            queryParameters.Add("@ContactName", parameters.ContactName);
            queryParameters.Add("@IsPan", parameters.IsPan);
            queryParameters.Add("@PanNumber", parameters.PanNumber);
            queryParameters.Add("@PanOriginalFileName", parameters.PanOriginalFileName);
            queryParameters.Add("@PanFileName", parameters.PanFileName);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveSupplier", queryParameters);
        }

        public async Task<int> DeleteSupplier(int Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);

            return await SaveByStoredProcedure<int>("DeleteSupplier", queryParameters);
        }

        public async Task<IEnumerable<Supplier_Response>> GetSupplierList(SupplierSearch_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<Supplier_Response>("GetSupplierList", queryParameters);

            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<Supplier_Response?> GetSupplierById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<Supplier_Response>("GetSupplierById", queryParameters)).FirstOrDefault();
        }
    }
}
