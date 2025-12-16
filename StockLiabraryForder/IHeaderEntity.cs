using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IHeaderEntity
    {
        Task<List<HeaderEntity>> GetAllHeaderEntities();
        Task<HeaderEntity?> GetHeaderEntityById(long id);

        Task<long> AddHeaderEntity(HeaderEntity h);
        Task<bool> UpdateHeaderEntity(HeaderEntity h);
        Task<bool> DeleteHeaderEntity(long id);

        Task<long> SaveDetailsAsync(HeaderEntity header, IEnumerable<OrderDetail> lines);

        Task<bool> SubmitAsync(long id);
        Task<bool> ApproveAsync(long id);
        Task<bool> RejectAsync(long id);
        Task<bool> CompleteAsync(long id);
        Task<bool> ReopenAsync(long id);

        Task<PurchaseOrderDto?> GetPurchaseOrderAsync(long id);
        Task<bool> MarkPurchaseOrderPrintedAsync(long headerId);

        Task<long> CreateDeliveryDraftAsync(long orderId, int destinationRefId, bool copyPrices = true, DateTime? entityDate = null);
        Task<bool> RefreshOrderStatusAsync(long orderId);

        Task<StockCheckResultDto> CheckRequestStockAsync(long requestHeaderId);
        Task<long> ApproveRequestAndIssueAsync(long requestHeaderId);



        // Purchase Request -> ORDER
        Task<long> CreateOrderFromRequestAsync(
            long requestHeaderId,
            int originRefId,
            DateTime? entityDate = null,
            string? extraNotes = null);

        Task<decimal> GetOnHandAsync(int storeRefId, int productId);
        Task ApproveDeliveryAndPostAsync(long deliveryId);
        Task<StockVerificationResultDto> VerifyStorekeeperAsync(long headerId);
        Task<bool> StorekeeperFinalizeVerificationAsync(long headerId, List<StockVerificationLine> updatedLines, string reason);

    }

}
