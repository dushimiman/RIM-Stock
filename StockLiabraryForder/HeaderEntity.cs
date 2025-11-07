using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class HeaderEntity
    {
        public long HeaderEntityID { get; set; }
        public DateTime EntityDate { get; set; }
        public string EntityNumber { get; set; } = string.Empty;
        public string EntityTypeCode { get; set; } = string.Empty; // ORDER/DELIVERY/REQUEST/DISTRIBUTION
        public int OriginRefID { get; set; }
        public int DestinationRefID { get; set; }
        public string StatusCode { get; set; } = "DRAFT";
        public string? Notes { get; set; }
    }
}