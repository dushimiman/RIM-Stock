namespace Z1StockLiabrary.StockLiabraryForder
{
    public class CreateOrderFromRequestDto
    {
        // 0 = auto-use DestinationRefID of the request (Main Store)
        public int OriginRefID { get; set; }

        public DateTime? EntityDate { get; set; }
        public string? ExtraNotes { get; set; }
    }
}
