using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IBillingDetailsRepository
    {
        Task<int> SaveBillingDetails(BillingDetails_Request parameters);

        Task<IEnumerable<BillingDetails_Response>> GetBillingDetailsList(Search_Request parameters);

        Task<BillingDetails_Response?> GetBillingDetailsById(long Id);
    }
}
