
namespace EasyBuy.Models
{
    public class SaleDetails
    {
        public long Id { get; set; }
        public long SaleId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal TotalValueInclGST { get; set; }
    }
}
