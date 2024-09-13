using System;

namespace EasyBuy.Models
{
    public class Bill
    {
        public long Id { get; set; }
        public required string Number { get; set; }
        public required DateTime Date { get; set; }
        public string SellerName { get; set; }
        public string CustomerType { get; set; }
        public string MemberId { get; set; }
        public decimal Total { get; set; }
    }
}
