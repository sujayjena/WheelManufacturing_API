using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IShippingDetailsRepository
    {
        Task<int> SaveShippingDetails(ShippingDetails_Request parameters);

        Task<IEnumerable<ShippingDetails_Response>> GetShippingDetailsList(Search_Request parameters);

        Task<ShippingDetails_Response?> GetShippingDetailsById(long Id);
    }
}
