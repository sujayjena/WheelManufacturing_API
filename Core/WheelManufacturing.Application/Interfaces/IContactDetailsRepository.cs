using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IContactDetailsRepository
    {
        Task<int> SaveContactDetails(ContactDetails_Request parameters);

        Task<IEnumerable<ContactDetails_Response>> GetContactDetailsList(Search_Request parameters);

        Task<ContactDetails_Response?> GetContactDetailsById(long Id);
    }
}
