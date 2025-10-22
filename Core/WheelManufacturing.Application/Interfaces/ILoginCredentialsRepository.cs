using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface ILoginCredentialsRepository
    {
        Task<int> SaveLoginCredentials(LoginCredentials_Request parameters);

        Task<IEnumerable<LoginCredentials_Response>> GetLoginCredentialsList(Search_Request parameters);

        Task<LoginCredentials_Response?> GetLoginCredentialsById(long Id);

        Task<string?> GetAutoGenPassword(string AutoPassword);
    }
}
