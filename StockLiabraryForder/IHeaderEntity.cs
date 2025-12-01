using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IHeaderEntity
    {
        // Reads
        Task<List<HeaderEntity>> GetAllHeaderEntities();
        Task<HeaderEntity?> GetHeaderEntityById(long id);

        // Writes
        Task<long> AddHeaderEntity(HeaderEntity h);
        Task<bool> UpdateHeaderEntity(HeaderEntity h);
        Task<bool> DeleteHeaderEntity(long id);

        // Save header + lines
        Task<long> SaveDetailsAsync(HeaderEntity header, IEnumerable<OrderDetail> lines);

        // Workflow
        Task<bool> SubmitAsync(long id);
        Task<bool> ApproveAsync(long id);
        Task<bool> RejectAsync(long id);
        Task<bool> CompleteAsync(long id);
        Task<bool> ReopenAsync(long id);

        // Purchase order
        Task<PurchaseOrderDto?> GetPurchaseOrderAsync(long id);
        Task<bool> MarkPurchaseOrderPrintedAsync(long headerId);

        // Delivery draft from ORDER
        Task<long> CreateDeliveryDraftAsync(long orderId, int destinationRefId, bool copyPrices = true, DateTime? entityDate = null);

        // Recompute order status from remaining qty
        Task<bool> RefreshOrderStatusAsync(long orderId);

        // REQUEST flows
        Task<StockCheckResultDto> CheckRequestStockAsync(long requestHeaderId);
        Task ApproveRequestAndIssueAsync(long requestHeaderId);

        // Utility
        Task<decimal> GetOnHandAsync(int storeRefId, int productId);
        Task ApproveDeliveryAndPostAsync(long deliveryId);
    }
}
