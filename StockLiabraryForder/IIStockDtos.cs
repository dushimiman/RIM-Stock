using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IStockDtos
    {
        Task<IReadOnlyList<StockOnHandDto>> GetOnHandAllAsync(CancellationToken ct = default);

        Task<IReadOnlyList<StockOnHandDto>> GetOnHandByStoreAsync(int storeRefId, CancellationToken ct = default);

        Task<decimal> GetOnHandAsync(int storeRefId, int productId, CancellationToken ct = default);

        Task<IReadOnlyList<StockOnHandDto>> SearchOnHandAsync(
            string search,
            int? storeRefId = null,
            CancellationToken ct = default);
    }
}
