using System.ComponentModel.DataAnnotations;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public sealed class OpeningStockDto
    {
        [Required]
        public int LocationRefID { get; set; }   // Main Store / Branch store RefID

        [Required]
        public int ProductID { get; set; }

        [Range(0.0001, double.MaxValue, ErrorMessage = "Quantity must be > 0")]
        public decimal Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }

        public string? Remarks { get; set; }
    }
}
