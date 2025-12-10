using System;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class HeaderEntity
    {
        public long HeaderEntityID { get; set; }
        public DateTime EntityDate { get; set; }
        public string EntityNumber { get; set; } = string.Empty;

        // ORDER / DELIVERY / DISTRIBUTION / ISSUE / REQ_STOCK / REQ_PURCHASE
        public string EntityTypeCode { get; set; } = string.Empty;

        public int OriginRefID { get; set; }
        public int DestinationRefID { get; set; }
        public string StatusCode { get; set; } = "DRAFT";
        public string? Notes { get; set; }
        public string? Specification { get; set; }

        // Link to parent: REQ_STOCK -> REQ_PURCHASE -> ORDER -> DELIVERY, etc.
        public long? ParentHeaderEntityID { get; set; }
    }
}
