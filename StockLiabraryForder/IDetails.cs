using System.Collections.Generic;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public interface IDetail
    {
        Task<List<OrderDetail>> GetDetailsByHeaderId(long headerId);
        Task<OrderDetail?> GetDetailById(long detailId);
        Task<long> AddDetail(OrderDetail d);
        Task<bool> UpdateDetail(OrderDetail d);
        Task<bool> DeleteDetail(long detailId);
        Task<bool> UpsertLinesForHeader(long headerId, IEnumerable<OrderDetail> lines);
    }
}
