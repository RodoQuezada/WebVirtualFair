using System;

namespace WebVirtualFair.Models
{
    public class ProductAvailableData
    {
        public long id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public char product_type { get; set; }
        public int  stock { get; set;}
        public string stock_unity { get; set; }
        public DateTime experition_date { get; set; }
    }
}