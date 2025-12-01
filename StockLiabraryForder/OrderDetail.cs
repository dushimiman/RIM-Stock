// Z1StockLiabrary/StockLiabraryForder/OrderDetail.cs
using System.ComponentModel.DataAnnotations;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class OrderDetail
    {
        public long DetailID { get; set; }                 // PK (IDENTITY)
        [Required] public long HeaderEntityID { get; set; } // FK -> HeaderEntity
        [Required] public int ProductID { get; set; }       // FK -> Product

        [Required, Range(0.0001, double.MaxValue)]
        public decimal Quantity { get; set; }               // decimal(18,3)

        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }              // decimal(18,4)

        public string? ProductName { get; set; }            // snapshot (optional)
        public string? Specification { get; set; }
    }
}
