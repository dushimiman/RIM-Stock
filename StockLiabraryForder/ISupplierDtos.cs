using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    
    public interface ISupplierDtos
    {
        
        Task<SupplierDtos?> GetAsync(int supplierId, CancellationToken ct = default);
        Task<IReadOnlyList<SupplierDtos>> GetAllAsync(bool? onlyActive = null, CancellationToken ct = default);
        Task<IReadOnlyList<SupplierDtos>> SearchAsync(string search, bool? onlyActive = null, CancellationToken ct = default);

        Task<SupplierDtos> CreateAsync(SupplierDtos supplier, CancellationToken ct = default);
        Task<bool> UpdateAsync(SupplierDtos supplier, CancellationToken ct = default);
        Task<bool> SetActiveAsync(int supplierId, bool isActive, CancellationToken ct = default);
    }
}
