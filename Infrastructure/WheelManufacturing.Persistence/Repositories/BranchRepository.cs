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
    public class BranchRepository : GenericRepository, IBranchRepository
    {
        private IConfiguration _configuration;

        public BranchRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> SaveBranch(Branch_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@BranchName", parameters.BranchName);
            queryParameters.Add("@CompanyId", parameters.CompanyId);
            queryParameters.Add("@EmailId", parameters.EmailId);
            queryParameters.Add("@MobileNo", parameters.MobileNo);
            queryParameters.Add("@DepartmentHead", parameters.DepartmentHead);
            queryParameters.Add("@AddressLine1", parameters.AddressLine1);
            queryParameters.Add("@AddressLine2", parameters.AddressLine2);
            queryParameters.Add("@CountryId", parameters.CountryId);
            queryParameters.Add("@StateId", parameters.StateId);
            queryParameters.Add("@DistrictId", parameters.DistrictId);
            queryParameters.Add("@Pincode", parameters.Pincode);
            if (SessionManager.LoggedInUserId == 1)
            {
                queryParameters.Add("@NoofUserAdd", parameters.NoofUserAdd);
            }
            queryParameters.Add("@IsBarcode", parameters.IsBarcode);
            queryParameters.Add("@BarcodeStartDate", parameters.BarcodeStartDate);
            queryParameters.Add("@BarcodeEndDate", parameters.BarcodeEndDate);
            queryParameters.Add("@BarcodePerPrice", parameters.BarcodePerPrice);
            queryParameters.Add("@CountOfBarcode", parameters.CountOfBarcode);
            queryParameters.Add("@IsQRcode", parameters.IsQRcode);
            queryParameters.Add("@QRcodeStartDate", parameters.QRcodeStartDate);
            queryParameters.Add("@QRcodeEndDate", parameters.QRcodeEndDate);
            queryParameters.Add("@QRcodePerPrice", parameters.QRcodePerPrice);
            queryParameters.Add("@CountOfQRcode", parameters.CountOfQRcode);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveBranch", queryParameters);
        }

        public async Task<IEnumerable<Branch_Response>> GetBranchList(BranchSearch_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@CompanyId", parameters.CompanyId);
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<Branch_Response>("GetBranchList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<Branch_Response?> GetBranchById(int Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<Branch_Response>("GetBranchById", queryParameters)).FirstOrDefault();
        }
    }
}
