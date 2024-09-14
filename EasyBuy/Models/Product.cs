
namespace EasyBuy.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Code { get; set; }        
        public string Catagory { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public decimal GSTPercentage { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal TotalPriceIncludingGST { get; set; }

    }
}
