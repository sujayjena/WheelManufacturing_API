using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelManufacturing.Domain.Entities;
using WheelManufacturing.Persistence.Repositories;

namespace WheelManufacturing.Application.Models
{
    #region Purchase Requisition
    public class PurchaseRequisition_Request : BaseEntity
    {
        public PurchaseRequisition_Request()
        {
            purchaseRequisitionDetails = new List<PurchaseRequisitionDetails_Request>();
        }
        public string? PurchaseRequisitionNo { get; set; }
        public DateTime? PurchaseRequisitionDate { get; set; }
        public int? RequestedBy { get; set; }
        public int? ReceivedBy { get; set; }
        public int? DepartmentId { get; set; }
        public int? StatusId { get; set; }
        public bool? IsActive { get; set; }
        public List<PurchaseRequisitionDetails_Request> purchaseRequisitionDetails { get; set; }
    }
    public class PurchaseRequisition_Search : BaseSearchEntity
    {
    }

    public class PurchaseRequisitionList_Response : BaseResponseEntity
    {
        public string? PurchaseRequisitionNo { get; set; }
        public DateTime? PurchaseRequisitionDate { get; set; }
        public int? RequestedBy { get; set; }
        public string? RequestedByName { get; set; }
        public int? ReceivedBy { get; set; }
        public string? ReceivedByName { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedByName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? StatusId { get; set; }
        public string? StatusName { get; set; }
        public bool? IsActive { get; set; }
    }
    public class PurchaseRequisition_Response : BaseResponseEntity
    {
        public PurchaseRequisition_Response()
        {
            purchaseRequisitionDetails = new List<PurchaseRequisitionDetails_Response>();
        }
        public string? PurchaseRequisitionNo { get; set; }
        public DateTime? PurchaseRequisitionDate { get; set; }
        public int? RequestedBy { get; set; }
        public string? RequestedByName { get; set; }
        public int? ReceivedBy { get; set; }
        public string? ReceivedByName { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedByName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? StatusId { get; set; }
        public string? StatusName { get; set; }
        public bool? IsActive { get; set; }
        public List<PurchaseRequisitionDetails_Response> purchaseRequisitionDetails { get; set; }
    }

    public class PurchaseRequisition_ApproveNReject
    {
        public int? Id { get; set; }
        public int? StatusId { get; set; }
        public string? Remarks { get; set; }
    }
    public class PurchaseRequisitionApproveNRejectHistory_Search : BaseSearchEntity
    {
        public int? PurchaseRequisitionId { get; set; }
    }
    public class PurchaseRequisitionApproveNRejectHistory_Response
    {
        public int? Id { get; set; }
        public int? PurchaseRequisitionId { get; set; }
        public string? Remarks { get; set; }
        public string? ApproveOrReject { get; set; }
        public string? CreatorName { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
    #endregion

    #region Purchase Requisition Details
    public class PurchaseRequisitionDetails_Request : BaseEntity
    {
        public int? PurchaseRequisitionId { get; set; }
        public int? MaterialMasterId { get; set; }
        public string? Specification { get; set; }
        public decimal? RequiredQty { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string? OrderRemarks { get; set; }
        public int? PriorityId { get; set; }
        public int? SupplierId { get; set; }
        public bool? IsActive { get; set; }
    }
    public class PurchaseRequisitionDetails_Search : BaseSearchEntity
    {
        public int? PurchaseRequisitionId { get; set; }
    }

    public class PurchaseRequisitionDetails_Response : BaseResponseEntity
    {
        public int? PurchaseRequisitionId { get; set; }
        public string? PurchaseRequisitionNo { get; set; }
        public int? MaterialMasterId { get; set; }
        public string? ItemCode { get; set; }
        public int? MaterialGroupId { get; set; }
        public string? MaterialGroup { get; set; }
        public int? MaterialCategoryId { get; set; }
        public string? MaterialCategory { get; set; }
        public int? UOMId { get; set; }
        public string? UOMName { get; set; }
        public string? Specification { get; set; }
        public decimal? RequiredQty { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string? OrderRemarks { get; set; }
        public int? PriorityId { get; set; }
        public string? PriorityName { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public bool? IsActive { get; set; }
    }
    #endregion
}
