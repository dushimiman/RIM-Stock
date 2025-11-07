using System.Collections.Generic;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class StockShortageDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public decimal RequiredQty { get; set; }
        public decimal OnHandQty { get; set; }
    }

    public class StockCheckResultDto
    {
        public bool IsOk { get; set; }               // true => can issue now
        public List<StockShortageDto> Shortages { get; set; } = new();
    }
}
