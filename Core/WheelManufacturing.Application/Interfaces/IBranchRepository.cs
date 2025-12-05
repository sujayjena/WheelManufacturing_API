using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IBranchRepository
    {
        Task<int> SaveBranch(Branch_Request parameters);

        Task<IEnumerable<Branch_Response>> GetBranchList(BranchSearch_Request parameters);

        Task<Branch_Response?> GetBranchById(int Id);
    }
}
