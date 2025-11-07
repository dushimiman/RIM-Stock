using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IProductDtos
    {
        Task<ProductDtos?> GetAsync(int productId, CancellationToken ct = default);
        Task<IReadOnlyList<ProductDtos>> GetAllAsync(bool? onlyActive = null, CancellationToken ct = default);
        Task<IReadOnlyList<ProductDtos>> SearchAsync(string search, bool? onlyActive = null, CancellationToken ct = default);
        Task<ProductDtos> CreateAsync(ProductDtos product, CancellationToken ct = default);
        Task<bool> UpdateAsync(ProductDtos product, CancellationToken ct = default);
        Task<bool> SetActiveAsync(int productId, bool isActive, CancellationToken ct = default);
    }
}
