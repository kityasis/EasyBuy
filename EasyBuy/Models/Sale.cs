using System;

namespace EasyBuy.Models
{
    public class Sale
    {
        public long Id { get; set; }
        public required string BillNumber { get; set; }
        public required DateTime Date { get; set; }
        public required string PaymentType { get; set; }        
        public string SellerName { get; set; }
        public string CustomerType { get; set; }
        public string MemberId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
