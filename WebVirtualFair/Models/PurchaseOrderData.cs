using System;

namespace WebVirtualFair.Models
{
    public class PurchaseOrderData
    {

        public long id { get; set; }
        public int quantity { get; set; }
        public DateTime shippingDate { get; set; }
        public Double customTax { get; set; }
        public Double commission { get; set; }
        public Double insuranceValue { get; set; }
        public Boolean insuranceStatus { get; set; }
        public PersonData PersonData { get; set; }

        public PurchaseOrderData()
        {
            this.insuranceStatus = true;
        }
    }
}