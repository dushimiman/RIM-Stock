using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface ILookupService
    {
        Task<List<OriginDestinationRef>> GetOriginDestinationsAsync();
        Task<List<Product>> GetProductsAsync();
        Task<List<Branch>> GetBranchesAsync();     // NEW
    }
}
