
namespace EasyBuy.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Supplier{ get; set; }
        public string Catagory { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public int Quantity { get; set; }       
        public decimal TotalBaseBuyPrice { get; set; }
        public decimal DiscountOnBaseBuyPrice { get; set; }
        public decimal TotalPurchaseDiscountAmount { get; set; }
        public decimal TotalBaseBuyPriceAfterDiscount { get; set; }
        public decimal InputGSTPercentage { get; set; }
        public decimal InputGSTAmount { get; set; }
        public decimal TotalPurchaseCostInclGST { get; set; }

    }
}
