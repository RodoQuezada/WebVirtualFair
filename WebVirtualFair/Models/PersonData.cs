using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirtualFair.Models
{
    public class PersonData
    {
        [Required]
        public long id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string lastName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string veryLastName { get; set; }
        public DateTime? birthDate { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string idNumber { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string idNumberType { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string phone { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string email { get; set;  }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string password { get; set; }
        
        public Boolean? status { get; set; }
        public int passwordRecovery { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updateAt { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string companyName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string idCompanyName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string position { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string comercialAddress { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string companyPhone { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
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