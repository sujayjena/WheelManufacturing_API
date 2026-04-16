using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.Application.Interfaces
{
    public interface IManagePurchaseRequisitionRepository
    {
        #region Purchase Requisition
        Task<int> SavePurchaseRequisition(PurchaseRequisition_Request parameters);
        Task<IEnumerable<PurchaseRequisitionList_Response>> GetPurchaseRequisitionList(PurchaseRequisition_Search parameters);
        Task<PurchaseRequisition_Response?> GetPurchaseRequisitionById(long Id);
        Task<int> PurchaseRequisitionApproveNReject(PurchaseRequisition_ApproveNReject parameters);
        Task<IEnumerable<PurchaseRequisitionApproveNRejectHistory_Response>> GetPurchaseRequisitionApproveNRejectHistoryListById(PurchaseRequisitionApproveNRejectHistory_Search parameters);
        #endregion

        #region Purchase Requisition Details
        Task<int> SavePurchaseRequisitionDetails(PurchaseRequisitionDetails_Request parameters);
        Task<IEnumerable<PurchaseRequisitionDetails_Response>> GetPurchaseRequisitionDetailsList(PurchaseRequisitionDetails_Search parameters);
        Task<int> DeletePurchaseRequisitionDetails(int Id);
        #endregion
    }
}
