using System.Collections.Generic;

namespace Z1StockLiabrary.StockLiabraryForder
{
    // Payload used to save a document with all its lines in one request.
    public class DocumentDto
    {
        public HeaderEntity Header { get; set; } = new();
        public List<OrderDetail> Lines { get; set; } = new();
    }
}
