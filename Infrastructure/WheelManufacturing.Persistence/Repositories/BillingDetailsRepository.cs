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
    public class BillingDetailsRepository : GenericRepository, IBillingDetailsRepository
    {
        private IConfiguration _configuration;

        public BillingDetailsRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> SaveBillingDetails(BillingDetails_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@RefId", parameters.RefId);
            queryParameters.Add("@RefType", parameters.RefType);
            queryParameters.Add("@IsNational_Or_International", parameters.IsNational_Or_International);
            queryParameters.Add("@AddressLine1", parameters.AddressLine1);
            queryParameters.Add("@CountryId", parameters.CountryId);
            queryParameters.Add("@StateId", parameters.StateId);
            queryParameters.Add("@DistrictId", parameters.DistrictId);
            queryParameters.Add("@CityId", parameters.CityId);
            queryParameters.Add("@PinCode", parameters.PinCode);
            queryParameters.Add("@IsGST", parameters.IsGST);
            queryParameters.Add("@GSTNumber", parameters.GSTNumber);
            queryParameters.Add("@GSTOriginalFileName", parameters.GSTOriginalFileName);
            queryParameters.Add("@GSTFileName", parameters.GSTFileName);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveBillingDetails", queryParameters);
        }

        public async Task<IEnumerable<BillingDetails_Response>> GetBillingDetailsList(Search_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@RefId", parameters.RefId);
            queryParameters.Add("@RefType", parameters.RefType);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<BillingDetails_Response>("GetBillingDetailsList", queryParameters);

            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<BillingDetails_Response?> GetBillingDetailsById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<BillingDetails_Response>("GetBillingDetailsById", queryParameters)).FirstOrDefault();
        }
    }
}
