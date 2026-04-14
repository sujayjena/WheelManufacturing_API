using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IManageSupplierPORepository
    {
        #region Supplier PO
        Task<int> SaveSupplierPO(SupplierPO_Request parameters);
        Task<IEnumerable<SupplierPOList_Response>> GetSupplierPOList(SupplierPO_Search parameters);
        Task<SupplierPO_Response?> GetSupplierPOById(int Id);

        #endregion

        #region Supplier PO Details
        Task<int> SaveSupplierPODetails(SupplierPODetails_Request parameters);
        Task<IEnumerable<SupplierPODetails_Response>> GetSupplierPODetailsList(SupplierPODetails_Search parameters);
        Task<int> DeleteSupplierPODetails(int Id);
        #endregion
    }
}
