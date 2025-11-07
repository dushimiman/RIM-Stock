using System.ComponentModel.DataAnnotations;

namespace Z1StockLiabrary.StockLiabraryForder
{
    public class ProductDtos
    {
        public int ProductID { get; set; }

        [Required, StringLength(200)]
        public string Descript { get; set; } = "";

        public bool IsActive { get; set; } = true;
    }
}
