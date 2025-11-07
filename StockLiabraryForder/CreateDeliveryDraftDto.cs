using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class CreateDeliveryDraftDto
    {
        public int DestinationRefID { get; set; }
        public bool CopyPrices { get; set; } = true;
        public DateTime? EntityDate { get; set; }
    }
}
