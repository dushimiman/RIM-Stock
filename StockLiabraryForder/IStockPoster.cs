using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IStockPoster
    {
        Task PostOrderApprovedAsync(long headerEntityId, CancellationToken ct);
        Task PostDistributionSuccessAsync(long headerEntityId, CancellationToken ct);
    }
}
