namespace Z1StockLiabrary.StockLiabraryForder
{
    public sealed class DeliveryNoteDto
    {
        public long HeaderEntityID { get; set; }
        public string EntityNumber { get; set; } = "";
        public DateTime EntityDate { get; set; }

        // Store receiving the goods
        public string DestinationName { get; set; } = "";

        // Supplier / origin
        public Supplier Supplier { get; set; } = new();

        // Optional: link to PO
        public string? ParentOrderNumber { get; set; }

        public List<OrderDetail> Lines { get; set; } = new();
    }
}
