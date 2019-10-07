using System.ComponentModel.DataAnnotations;

namespace WebVirtualFair.Models
{
    public class AddressData
    {
        [Required]
        public long id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string country { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string city { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string address { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string addressNumber { get; set; }

    }
}