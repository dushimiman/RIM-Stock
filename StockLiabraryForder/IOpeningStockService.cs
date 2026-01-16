using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IOpeningStockService
    {
        /// <summary>
        /// Registers opening stock in the system for a given product and store.
        /// This should be called only once per product/location when migrating manual stock.
        /// </summary>
        Task AddOpeningStockAsync(OpeningStockDto dto);
    }
}
