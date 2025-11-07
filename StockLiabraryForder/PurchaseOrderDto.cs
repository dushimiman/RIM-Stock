using System;
using System.Collections.Generic;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public sealed class PurchaseOrderDto
    {
        public long HeaderEntityID { get; set; }
        public string EntityNumber { get; set; } = "";
        public DateTime EntityDate { get; set; }

        public string OriginName { get; set; } = "";   // store name
        public Supplier Supplier { get; set; } = new(); // full supplier info

        public List<PurchaseOrderLineDto> Lines { get; set; } = new(); // order lines
    }

    public sealed class PurchaseOrderLineDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
