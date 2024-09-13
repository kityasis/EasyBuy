
namespace EasyBuy.Models
{
    public class Sale
    {
        public long Id { get; set; }
        public string ProductCode { get; set; }     
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }    
        public decimal BasePrice { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalBasePriceAfterDiscount { get; set; }
        public decimal GSTPercentage { get; set; }
        public decimal GstAmount { get; set; }
        public decimal TotalValueInclGST { get; set; }
    }
}
