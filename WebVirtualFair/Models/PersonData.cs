using System;
using System.Collections.Generic;

namespace WebVirtualFair.Models
{
    public class PersonData
    {
            
        public long id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string veryLastName { get; set; }
        public DateTime? birthDate { get; set; }
        public string idNumber { get; set; }
        public string idNumberType { get; set; }
        public string phone { get; set; }
        public string email { get; set;  }
        public string password { get; set; }
        public Boolean? status { get; set; }
        public int passwordRecovery { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updateAt { get; set; }
        public string companyName { get; set; }
        public string idCompanyName { get; set; }
        public string position { get; set; }
        public string comercialAddress { get; set; }
        public string companyPhone { get; set; }
        public string companyEmail { get; set; }
        public int roleId { get; set; }
        
        public virtual List<PurchaseOrderData> purchaseOrderDatas { get; set; }

        public PersonData()
        {
            this.status = true;
            this.passwordRecovery = 0;
            this.createdAt = DateTime.Today;
        }
    }
}