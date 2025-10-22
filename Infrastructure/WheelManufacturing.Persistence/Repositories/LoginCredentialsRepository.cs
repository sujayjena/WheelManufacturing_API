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
    public class LoginCredentialsRepository : GenericRepository, ILoginCredentialsRepository
    {
        private IConfiguration _configuration;

        public LoginCredentialsRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> SaveLoginCredentials(LoginCredentials_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@RefId", parameters.RefId);
            queryParameters.Add("@RefType", parameters.RefType);
            queryParameters.Add("@ContactName", parameters.ContactName);
            queryParameters.Add("@MobileNo", parameters.MobileNo);
            queryParameters.Add("@Passwords", !string.IsNullOrWhiteSpace(parameters.Passwords) ? EncryptDecryptHelper.EncryptString(parameters.Passwords) : string.Empty);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveLoginCredentials", queryParameters);
        }

        public async Task<IEnumerable<LoginCredentials_Response>> GetLoginCredentialsList(Search_Request parameters)
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

            var result = await ListByStoredProcedure<LoginCredentials_Response>("GetLoginCredentialsList", queryParameters);

            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<LoginCredentials_Response?> GetLoginCredentialsById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<LoginCredentials_Response>("GetLoginCredentialsById", queryParameters)).FirstOrDefault();
        }

        public async Task<string?> GetAutoGenPassword(string AutoPassword)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@AutoPassword", AutoPassword, null, System.Data.ParameterDirection.Output);

            var result = await SaveByStoredProcedure<string>("sp_AutoGenPassword", queryParameters);
            AutoPassword = queryParameters.Get<string>("AutoPassword");

            return AutoPassword;
        }
    }
}
