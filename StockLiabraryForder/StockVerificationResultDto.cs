public class StockVerificationResultDto
{
    public bool IsOk { get; set; }
    public List<StockVerificationLine> Lines { get; set; } = new();
}

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class StorekeeperFinalizeRequestDto
    {
        public long HeaderId { get; set; }
        public string Reason { get; set; } = string.Empty;
        public List<StockVerificationLine> Lines { get; set; } = new();
    }
}


public class StockVerificationLine
{
    public int ProductID { get; set; }
    public string ProductName { get; set; } = "";
    public string Specification { get; set; } = "";
    public decimal RequiredQty { get; set; }
    public decimal OnHandQty { get; set; }
    public decimal EditableQty { get; set; }  // user may modify if shortage
}
