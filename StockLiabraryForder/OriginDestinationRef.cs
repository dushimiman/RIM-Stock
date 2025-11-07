// Z1StockLiabrary/StockLiabraryForder/OriginDestinationRef.cs
namespace Z1StockLiabrary.StockLiabraryForder
{
    public class OriginDestinationRef
    {
        public int OriginDestinationRefID { get; set; }   // maps dbo.OriginDestinationRef.RefID
        public string TypeCode { get; set; } = "";        // "STORE" | "BRANCH" | others
        public int? SupplierID { get; set; }              // nullable
        public int? BranchID { get; set; }                // nullable (Alpha branch ID when TypeCode='BRANCH')
        public string Name { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public decimal? DefaultUnitPrice { get; set; }
    }

    // Z1StockLiabrary/StockLiabraryForder/OriginDestinationRef.cs  (append to Supplier)
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; } = "";
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? AddressLine { get; set; }
        public bool IsActive { get; set; } = true;
    }


    public class Branch
    {
        public int BranchID { get; set; }                 // Alpha’s ID (from TSc550Branch.ID)
        public string BranchName { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
