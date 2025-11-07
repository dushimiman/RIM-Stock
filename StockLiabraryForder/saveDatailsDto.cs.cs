// Z0StockAPI/Contracts/SaveDocumentDto.cs
using System.Collections.Generic;
using Z1StockLiabrary.StockLiabraryForder;

namespace Z0StockAPI.Contracts
{
    public class SaveDetailsDto
    {
        public HeaderEntity Header { get; set; } = new();
        public List<OrderDetail> Lines { get; set; } = new();
    }
}
