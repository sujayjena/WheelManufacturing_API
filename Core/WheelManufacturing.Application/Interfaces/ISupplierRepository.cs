using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface ISupplierRepository
    {
        Task<int> SaveSupplier(Supplier_Request parameters);

        Task<int> DeleteSupplier(int Id);

        Task<IEnumerable<Supplier_Response>> GetSupplierList(SupplierSearch_Request parameters);

        Task<Supplier_Response?> GetSupplierById(long Id);
    }
}
