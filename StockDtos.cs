using System.Collections.Generic;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public sealed class StockOnHandDto
    {
        public int ProductID { get; set; }
        public string ItemCode { get; set; } = "";
        public string ItemName { get; set; } = "";
        public decimal QuantityOnHand { get; set; }

        // Only filled when requesting ALL stores
        public List<StoreQtyDto>? StoreBreakdown { get; set; }
    }

    public sealed class StoreQtyDto
    {
        public int StoreRefID { get; set; }
        public string StoreName { get; set; } = "";
        public decimal Qty { get; set; }
    }
}
